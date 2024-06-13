using ECMS.DTO;
using ECMS.DTO.Supplier;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacilityController : ControllerBase
    {
        private readonly FacilityService _facilityService;

        public FacilityController(FacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFacilitiesAsync(CancellationToken token)
        {
            var facilities = await _facilityService.GetFacilities(token);
            return Ok(facilities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFacility(int id, CancellationToken token)
        {
            var facility = await _facilityService.GetFacility(id, token);
            return Ok(facility);
        }

        [HttpPost]
        public async Task<IActionResult> AddFacility([FromBody] FacilityDto facilityDto)
        {
            var facility = new Facility
            {
                Name = facilityDto.Name,
                AddressId = facilityDto.AddressId,
                Description = facilityDto.Description,
                Capacity = facilityDto.Capacity
            };
            
            var newFacility = await _facilityService.AddFacility(facility);
            return Ok(newFacility);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFacility(int id, [FromBody] FacilityDto facility, CancellationToken token)
        {
            var existingFacility = await _facilityService.GetFacility(id, token);
            if (existingFacility == null)
            {
                return NotFound();
            }
            
            var updatedFacility = await _facilityService.UpdateFacility(existingFacility);
            return Ok(updatedFacility);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacility(int id)
        {
            await _facilityService.DeleteFacility(id);
            return Ok();
        }


        [HttpPost("assign-supplier")]
        public async Task<IActionResult> AssignSupplier([FromBody] AssignSupplierDto dto)
        {
            var updatedFacility = await _facilityService.AssignSupplier(dto.FacilityId, dto.SupplierId);
            return Ok(updatedFacility);
        }
        
        [HttpPost("remove-supplier")]
        public async Task<IActionResult> RemoveSupplier([FromBody] AssignSupplierDto dto)
        {
            var updatedFacility = await _facilityService.RemoveSupplier(dto.FacilityId, dto.SupplierId);
            return Ok(updatedFacility);
        }
        
        [HttpPost("assign-area")]
        public async Task<IActionResult> AssignArea([FromBody] AssignAreaDto dto)
        {
            var updatedFacility = await _facilityService.AssignArea(dto.FacilityId, dto.AreaId);
            return Ok(updatedFacility);
        }
        
        [HttpPost("remove-area")]
        public async Task<IActionResult> RemoveArea([FromBody] AssignAreaDto dto)
        {
            var updatedFacility = await _facilityService.RemoveArea(dto.FacilityId, dto.AreaId);
            return Ok(updatedFacility);
        }
    }
}