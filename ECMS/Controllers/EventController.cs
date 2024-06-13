using ECMS.DTO;
using ECMS.Enums;
using Microsoft.AspNetCore.Mvc;
using ECMS.Services;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController(EventService service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetEvents(CancellationToken token)
        {
            var events = await service.GetAllEventsAsync(token);
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent(int id, CancellationToken token)
        {
            var eventItem = await service.GetEventByIdAsync(id, token);
            return Ok(eventItem);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent([FromBody] EventDto eventDto)
        {
            var eventItem = await service.AddEventAsync(eventDto);
            return Ok(eventItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventDto eventDto)
        {
            var eventItem = await service.UpdateEventAsync(id, eventDto);
            return Ok(eventItem);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await service.DeleteEventAsync(id);
            return NoContent();
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> RegisterForEvent([FromBody] EventRegistrationDto eventRegistrationDto)
        {
            await service.RegisterForEventAsync(eventRegistrationDto);
            return Ok("Registration successful");
        }
        
        
        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetEventsByCategory(EventCategory category, CancellationToken token)
        {
            var events = await service.GetEventsByCategoryAsync(category, token);
            return Ok(events);
        }
    }
}