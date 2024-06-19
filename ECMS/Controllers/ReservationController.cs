using ECMS.DTO.Reservation;
using ECMS.Enums;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly ReservationService _service;

    public ReservationController(ReservationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetReservations(CancellationToken token)
    {
        var reservations = await _service.GetAllReservationsAsync(token);
        return Ok(reservations);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetReservation(int id, CancellationToken token)
    {
        var reservation = await _service.GetReservationByIdAsync(id, token);
        return Ok(reservation);
    }
    
    [HttpGet("area/{areaId}/date/{date}")]
    public async Task<IActionResult> GetReservationsByAreaAndDate(int areaId, string date, CancellationToken token)
    {
        var reservations = await _service.GetReservationsByAreaAndDateAsync(areaId, date, token);
        return Ok(reservations);
    }

    [HttpPost]
    public async Task<IActionResult> AddReservation([FromBody] MakeReservationDto reservationDto)
    {
        var reservation = await _service.AddReservationAsync(reservationDto);
        return Ok(reservation);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateReservation(int id, [FromBody] ReservationDto reservationDto)
    {
        var reservation = await _service.UpdateReservationAsync(id, reservationDto);
        return Ok(reservation);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReservation(int id)
    {
        await _service.DeleteReservationAsync(id);
        return NoContent();
    }

    [HttpGet("status/{status}")]
    public async Task<IActionResult> GetReservationsByStatus(ReservationStatus status, CancellationToken token)
    {
        var reservations = await _service.GetReservationsByStatusAsync(status, token);
        return Ok(reservations);
    }

    [HttpPost("confirm/{id}")]
    public async Task<IActionResult> ConfirmReservation(int id)
    {
        await _service.ConfirmReservationAsync(id);
        return NoContent();
    }

    [HttpPost("cancel/{id}")]
    public async Task<IActionResult> CancelReservation(int id)
    {
        await _service.CancelReservationAsync(id);
        return NoContent();
    }

    [HttpPost("complete/{id}")]
    public async Task<IActionResult> CompleteReservation(int id)
    {
        await _service.CompleteReservationAsync(id);
        return NoContent();
    }
    
    [HttpGet("count")]
    public IActionResult GetTotalReservations()
    {
        return Ok(Reservation.TotalReservations);
    }
}