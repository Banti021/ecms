using ECMS.DTO.Area;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : ControllerBase
    {
        private readonly AreaService _areaService;

        public AreaController(AreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAreas(CancellationToken token)
        {
            var areas = await _areaService.GetAreas(token);
            return Ok(areas);
        }

        [HttpGet("{areaId}")]
        public async Task<IActionResult> GetArea(int areaId, CancellationToken token)
        {
            var area = await _areaService.GetArea(areaId, token);
            if (area == null)
            {
                return NotFound();
            }
            return Ok(area);
        }

        [HttpPost]
        public async Task<IActionResult> AddArea([FromBody] AreaDto dto)
        {
            var area = new Area
            {
                Name = dto.Name,
                Description = dto.Description,
                Capacity = dto.Capacity,
                IsAvailable = dto.IsAvailable,
                FacilityId = dto.FacilityId
            };
            
            var newArea = await _areaService.AddArea(area);
            
            return CreatedAtAction(nameof(GetArea), new { areaId = newArea.Id }, newArea);
        }

        [HttpPut("{areaId}")]
        public async Task<IActionResult> UpdateArea(int areaId, [FromBody] AreaDto dto, CancellationToken token)
        {
            var area = await _areaService.GetArea(areaId, token);
            if (area == null)
            {
                return NotFound();
            }

            var updatedArea = await _areaService.UpdateArea(area);
            return Ok(updatedArea);
        }

        [HttpDelete("{areaId}")]
        public async Task<IActionResult> DeleteArea(int areaId, CancellationToken token)
        {
            var area = await _areaService.GetArea(areaId, token);
            if (area == null)
            {
                return NotFound();
            }

            await _areaService.DeleteArea(areaId);
            return NoContent();
        }
        
        [HttpGet("facility/{facilityId}")]
        public async Task<IActionResult> GetAreasByFacility(int facilityId, CancellationToken token)
        {
            var areas = await _areaService.GetAreasByFacility(facilityId, token);
            if (areas == null || areas.Count == 0)
            {
                return NotFound("No areas found for the given facility ID.");
            }
            return Ok(areas);
        }
    }
}
