using ECMS.DTO.Ticket;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketController(TicketService ticketService): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTickets(CancellationToken cancellationToken)
    {
        var tickets = await ticketService.GetTicketsAsync(cancellationToken);
        return Ok(tickets);
    }

    [HttpGet("{ticketId}")]
    public async Task<IActionResult> GetTicketById(int ticketId, CancellationToken cancellationToken)
    {
        var ticket = await ticketService.GetTicketAsync(ticketId, cancellationToken);
        if (ticket == null)
        {
            return NotFound("Ticket not found.");
        }
        return Ok(ticket);
    }
    
    [HttpGet("customer/{customerId}")]
    public async Task<IActionResult> GetTicketByCustomerId(int customerId, CancellationToken cancellationToken)
    {
        var ticket = await ticketService.GetTicketByCustomerIdAsync(customerId, cancellationToken);
        if (ticket == null)
        {
            return NotFound("Ticket not found.");
        }
        return Ok(ticket);
    }
}