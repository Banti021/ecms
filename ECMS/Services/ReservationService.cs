using ECMS.Context;
using ECMS.DTO.Reservation;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ECMS.Services;

public class ReservationService(ApplicationContext context)
{
    public async Task<List<ReservationDto>> GetAllReservationsAsync(CancellationToken token)
    {
        var reservations = await context.Reservations.Select(r => new ReservationDto
        {
            Id = r.Id,
            ReservationFrom = r.ReservationFrom,
            ReservationTo = r.ReservationTo,
            Status = r.Status,
            Category = r.Category,
            NumberOfGuests = r.NumberOfGuests,
            ConfirmedAt = r.ConfirmedAt ?? DateTime.MinValue,
            AdditionalInfo = r.AdditionalInfo
        }).ToListAsync(token);
            
        // Update the total reservations count
        await Reservation.CalculateTotalReservations(context);
            
        return reservations;
    }

    public async Task<ReservationDto> GetReservationByIdAsync(int id, CancellationToken token)
    {
        var reservation = await context.Reservations.FindAsync(new object[] { id }, token);
        if (reservation == null) throw new Exception("Reservation not found");

        return new ReservationDto
        {
            Id = reservation.Id,
            ReservationFrom = reservation.ReservationFrom,
            ReservationTo = reservation.ReservationTo,
            Status = reservation.Status,
            Category = reservation.Category,
            NumberOfGuests = reservation.NumberOfGuests,
            ConfirmedAt = reservation.ConfirmedAt ?? null,
            AdditionalInfo = reservation.AdditionalInfo
        };
    }

    public async Task<ReservationDto> AddReservationAsync(MakeReservationDto reservationDto)
    {
        Console.WriteLine($"ReservationDto: {JsonConvert.SerializeObject(reservationDto)}");

        var customer = await context.Customers
            .Include(c => c.Reservations)
            .FirstOrDefaultAsync(c => c.Id == reservationDto.CustomerId);
        if (customer == null) throw new Exception($"Customer with ID {reservationDto.CustomerId} not found");

        var area = await context.Areas
            .Include(a => a.ReservationAreas)
            .FirstOrDefaultAsync(a => a.Id == reservationDto.AreaId);
        if (area == null) throw new Exception($"Area with ID {reservationDto.AreaId} not found");

        var reservation = new Reservation
        {
            ReservationFrom = reservationDto.ReservationFrom,
            ReservationTo = reservationDto.ReservationTo,
            Status = ReservationStatus.Created,
            Category = reservationDto.Category,
            NumberOfGuests = reservationDto.NumberOfGuests,
            ConfirmedAt = null,
            ReservationAreas = new List<ReservationArea>(),
            AdditionalInfo = reservationDto.AdditionalInfo
        };

        var reservationArea = new ReservationArea
        {
            AreaId = area.Id,
            Reservation = reservation
        };

        reservation.ReservationAreas.Add(reservationArea);
        customer.Reservations.Add(reservation);

        context.Reservations.Add(reservation);
        await context.SaveChangesAsync();
        
        await Reservation.CalculateTotalReservations(context);

        return new ReservationDto
        {
            Id = reservation.Id,
            ReservationFrom = reservation.ReservationFrom,
            ReservationTo = reservation.ReservationTo,
            Status = reservation.Status,
            Category = reservation.Category,
            NumberOfGuests = reservation.NumberOfGuests,
            ConfirmedAt = reservation.ConfirmedAt,
            AdditionalInfo = reservation.AdditionalInfo
        };
    }

    public async Task<ReservationDto> UpdateReservationAsync(int id, ReservationDto reservationDto)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.ReservationFrom = reservationDto.ReservationFrom;
        reservation.ReservationTo = reservationDto.ReservationTo;
        reservation.Status = reservationDto.Status;
        reservation.Category = reservationDto.Category;
        reservation.NumberOfGuests = reservationDto.NumberOfGuests;
        reservation.ConfirmedAt = reservationDto.ConfirmedAt;
        reservation.AdditionalInfo = reservationDto.AdditionalInfo;
        
        await context.SaveChangesAsync();
        
        await Reservation.CalculateTotalReservations(context);
        
        return reservationDto;
    }

    public async Task DeleteReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        context.Reservations.Remove(reservation);
        await context.SaveChangesAsync();
            
        // Update the total reservations count
        await Reservation.CalculateTotalReservations(context);
    }

    public async Task ConfirmReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Reserved;
        reservation.ConfirmedAt = DateTime.Now;

        await context.SaveChangesAsync();
            
        // Update the total reservations count
        await Reservation.CalculateTotalReservations(context);
    }

    public async Task CancelReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Cancelled;

        await context.SaveChangesAsync();
            
        // Update the total reservations count
        await Reservation.CalculateTotalReservations(context);
    }

    public async Task CompleteReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Completed;

        await context.SaveChangesAsync();
            
        // Update the total reservations count
        await Reservation.CalculateTotalReservations(context);
    }

    public async Task<List<ReservationDto>> GetReservationsByStatusAsync(ReservationStatus status, CancellationToken token)
    {
        var reservations = await context.Reservations
            .Where(r => r.Status == status)
            .Select(r => new ReservationDto
            {
                Id = r.Id,
                ReservationFrom = r.ReservationFrom,
                ReservationTo = r.ReservationTo,
                Status = r.Status,
                Category = r.Category,
                NumberOfGuests = r.NumberOfGuests,
                ConfirmedAt = r.ConfirmedAt ?? DateTime.MinValue
            }).ToListAsync(token);
        
        await Reservation.CalculateTotalReservations(context);
            
        return reservations;
    }
}
