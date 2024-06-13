using ECMS.Context;
using ECMS.DTO;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ECMS.Enums;

namespace ECMS.Services
{
    public class EventService
    {
        private readonly ApplicationContext _context;

        public EventService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<EventDto>> GetAllEventsAsync(CancellationToken token)
        {
            var events = await _context.Events.Select(e => new EventDto
            {
                Id = e.Id,
                Title = e.Title,
                EventCategory = e.EventCategory,
                RegularPrice = e.RegularPrice,
                VipPrice = e.VipPrice,
                StartTime = e.StartTime,
                EndTime = e.EndTime,
                Description = e.Description,
                MaxAttendees = e.MaxAttendees,
                CurrentAttendees = e.CurrentAttendees
            }).ToListAsync(token);

            return events;
        }
        
        public async Task<EventDto> GetEventByIdAsync(int id, CancellationToken token)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null) throw new Exception("Event not found");
            return new EventDto
            {
                Id = eventItem.Id,
                Title = eventItem.Title,
                EventCategory = eventItem.EventCategory,
                RegularPrice = eventItem.RegularPrice,
                VipPrice = eventItem.VipPrice,
                StartTime = eventItem.StartTime,
                EndTime = eventItem.EndTime,
                Description = eventItem.Description,
                MaxAttendees = eventItem.MaxAttendees,
                CurrentAttendees = eventItem.CurrentAttendees
            };
        }
        
        public async Task<EventDto> AddEventAsync(EventDto eventDto)
        {
            var eventItem = new Event
            {
                Title = eventDto.Title,
                EventCategory = eventDto.EventCategory,
                RegularPrice = eventDto.RegularPrice,
                VipPrice = eventDto.VipPrice,
                StartTime = eventDto.StartTime,
                EndTime = eventDto.EndTime,
                Description = eventDto.Description,
                MaxAttendees = eventDto.MaxAttendees,
                CurrentAttendees = 0
            };
            
            await _context.Events.AddAsync(eventItem);
            await _context.SaveChangesAsync();
            
            return new EventDto
            {
                Id = eventItem.Id,
                Title = eventItem.Title,
                EventCategory = eventItem.EventCategory,
                RegularPrice = eventItem.RegularPrice,
                VipPrice = eventItem.VipPrice,
                StartTime = eventItem.StartTime,
                EndTime = eventItem.EndTime,
                Description = eventItem.Description,
                MaxAttendees = eventItem.MaxAttendees,
                CurrentAttendees = eventItem.CurrentAttendees
            };
        }
        
        public async Task<EventDto> UpdateEventAsync(int id, EventDto eventDto)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null) throw new Exception("Event not found");
            
            eventItem.Title = eventDto.Title;
            eventItem.EventCategory = eventDto.EventCategory;
            eventItem.RegularPrice = eventDto.RegularPrice;
            eventItem.VipPrice = eventDto.VipPrice;
            eventItem.StartTime = eventDto.StartTime;
            eventItem.EndTime = eventDto.EndTime;
            eventItem.Description = eventDto.Description;
            eventItem.MaxAttendees = eventDto.MaxAttendees;
            
            await _context.SaveChangesAsync();
            
            return new EventDto
            {
                Id = eventItem.Id,
                Title = eventItem.Title,
                EventCategory = eventItem.EventCategory,
                RegularPrice = eventItem.RegularPrice,
                VipPrice = eventItem.VipPrice,
                StartTime = eventItem.StartTime,
                EndTime = eventItem.EndTime,
                Description = eventItem.Description,
                MaxAttendees = eventItem.MaxAttendees,
                CurrentAttendees = eventItem.CurrentAttendees
            };
        }
        
        public async Task DeleteEventAsync(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null) throw new Exception("Event not found");
            
            _context.Events.Remove(eventItem);
            await _context.SaveChangesAsync();
        }
        
        public async Task RegisterForEventAsync(EventRegistrationDto eventRegistrationDto)
        {
            var eventItem = await _context.Events.FindAsync(eventRegistrationDto.EventId);
            if (eventItem == null) throw new Exception("Event not found");

            var customer = await _context.Customers.FindAsync(eventRegistrationDto.CustomerId);
            if (customer == null) throw new Exception("Customer not found");

            if (eventItem.CurrentAttendees >= eventItem.MaxAttendees) throw new Exception("Event is full");

            eventItem.CurrentAttendees++;
            await _context.SaveChangesAsync();

            var ticket = new Ticket
            {
                Price = eventRegistrationDto.TicketPrice,
                IsSeated = !string.IsNullOrEmpty(eventRegistrationDto.SeatNumber),
                SeatNumber = eventRegistrationDto.SeatNumber,
                TicketType = eventRegistrationDto.TicketType
            };

            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();

            var eventCustomer = new EventCustomer
            {
                EventId = eventRegistrationDto.EventId,
                CustomerId = eventRegistrationDto.CustomerId,
                TicketId = ticket.Id
            };

            await _context.EventCustomers.AddAsync(eventCustomer);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<EventDto>> GetEventsByCategoryAsync(EventCategory category, CancellationToken token)
        {
            var events = await _context.Events.Where(e => e.EventCategory == category)
                .Select(e => new EventDto
                {
                    Id = e.Id,
                    Title = e.Title,
                    EventCategory = e.EventCategory,
                    RegularPrice = e.RegularPrice,
                    VipPrice = e.VipPrice,
                    StartTime = e.StartTime,
                    EndTime = e.EndTime,
                    Description = e.Description,
                    MaxAttendees = e.MaxAttendees,
                    CurrentAttendees = e.CurrentAttendees
                }).ToListAsync(token);
            
            return events;
        }
        
        public async Task<List<EventDto>> GetEventsForCustomerAsync(int customerId, CancellationToken token)
        {
            var events = await _context.EventCustomers.Where(ec => ec.CustomerId == customerId)
                .Select(ec => new EventDto
                {
                    Id = ec.EventId,
                    Title = ec.Event.Title,
                    EventCategory = ec.Event.EventCategory,
                    RegularPrice = ec.Event.RegularPrice,
                    VipPrice = ec.Event.VipPrice,
                    StartTime = ec.Event.StartTime,
                    EndTime = ec.Event.EndTime,
                    Description = ec.Event.Description,
                    MaxAttendees = ec.Event.MaxAttendees,
                    CurrentAttendees = ec.Event.CurrentAttendees
                }).ToListAsync(token);
            
            return events;
        }
    }
}
