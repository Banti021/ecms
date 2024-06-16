using ECMS.Context;
using ECMS.DTO.Ticket;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class TicketService(ApplicationContext context)
{
    public async Task<TicketDto?> GetTicketAsync(int ticketId, CancellationToken cancellationToken)
    {
        return await context.Tickets
            .Where(t => t.Id == ticketId)
            .Select(t => new TicketDto
            {
                Id = t.Id,
                Price = t.Price,
                IsSeated = t.IsSeated,
                SeatNumber = t.SeatNumber,
                TicketType = t.TicketType
            })
            .FirstOrDefaultAsync(cancellationToken);
    }
    
    public async Task<List<TicketDto>> GetTicketsAsync(CancellationToken cancellationToken)
    {
        return await context.Tickets
            .Select(t => new TicketDto
            {
                Id = t.Id,
                Price = t.Price,
                IsSeated = t.IsSeated,
                SeatNumber = t.SeatNumber,
                TicketType = t.TicketType
            })
            .ToListAsync(cancellationToken);
    }
    
    public async Task<TicketDto?> GetTicketByCustomerIdAsync(int customerId, CancellationToken cancellationToken)
    {
        return await context.Tickets
            .Where(t => t.EventCustomers.Any(ec => ec.CustomerId == customerId))
            .Select(t => new TicketDto
            {
                Id = t.Id,
                Price = t.Price,
                IsSeated = t.IsSeated,
                SeatNumber = t.SeatNumber,
                TicketType = t.TicketType
            })
            .FirstOrDefaultAsync(cancellationToken);
    }
}