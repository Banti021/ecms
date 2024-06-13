using ECMS.Context;
using ECMS.DTO.Reservation;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class ReservationService(ApplicationContext context)
{
    public async Task<List<ReservationDto>> GetAllReservationsAsync(CancellationToken token)
    {
        return await context.Reservations.Select(r => new ReservationDto
        {
            Id = r.Id,
            ReservationFrom = r.ReservationFrom,
            ReservationTo = r.ReservationTo,
            Status = r.Status,
            Category = r.Category,
            NumberOfGuests = r.NumberOfGuests,
            ConfirmedAt = r.ConfirmedAt ?? DateTime.MinValue
        }).ToListAsync(token);
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
            ConfirmedAt = reservation.ConfirmedAt ?? null
        };
    }

    public async Task<ReservationDto> AddReservationAsync(MakeReservationDto reservationDto)
    {
        var customer = await context.Customers
                                     .Include(c => c.Reservations)
                                     .FirstOrDefaultAsync(c => c.Id == reservationDto.CustomerId);
        if (customer == null) throw new Exception("Customer not found");

        var area = await context.Areas
                                 .Include(a => a.ReservationAreas)
                                 .FirstOrDefaultAsync(a => a.Id == reservationDto.AreaId);
        if (area == null) throw new Exception("Area not found");

        var reservation = new Reservation
        {
            ReservationFrom = reservationDto.ReservationFrom,
            ReservationTo = reservationDto.ReservationTo,
            Status = ReservationStatus.Created,
            Category = reservationDto.Category,
            NumberOfGuests = reservationDto.NumberOfGuests,
            ConfirmedAt = null,
            ReservationAreas = new List<ReservationArea>()
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

        return new ReservationDto
        {
            Id = reservation.Id,
            ReservationFrom = reservation.ReservationFrom,
            ReservationTo = reservation.ReservationTo,
            Status = reservation.Status,
            Category = reservation.Category,
            NumberOfGuests = reservation.NumberOfGuests,
            ConfirmedAt = reservation.ConfirmedAt
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

        await context.SaveChangesAsync();
        return reservationDto;
    }

    public async Task DeleteReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        context.Reservations.Remove(reservation);
        await context.SaveChangesAsync();
    }

    public async Task ConfirmReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Reserved;
        reservation.ConfirmedAt = DateTime.Now;

        await context.SaveChangesAsync();
    }

    public async Task CancelReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Cancelled;

        await context.SaveChangesAsync();
    }

    public async Task CompleteReservationAsync(int id)
    {
        var reservation = await context.Reservations.FindAsync(id);
        if (reservation == null) throw new Exception("Reservation not found");

        reservation.Status = ReservationStatus.Completed;

        await context.SaveChangesAsync();
    }

    public async Task<List<ReservationDto>> GetReservationsByStatusAsync(ReservationStatus status, CancellationToken token)
    {
        return await context.Reservations
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
    }
}
