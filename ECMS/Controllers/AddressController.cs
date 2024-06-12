using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ECMS.DTO;

namespace ECMS.Controllers
{
    [Route("api/address")]
    public class AddressController(AddressService addressService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAddresses(CancellationToken cancellationToken)
        {
            var addresses = await addressService.GetAddressesAsync(cancellationToken);
            return Ok(addresses);
        }

        [HttpGet("{addressId}")]
        public async Task<IActionResult> GetAddressById(int addressId, CancellationToken cancellationToken)
        {
            var address = await addressService.GetAddressAsync(addressId, cancellationToken);
            if (address == null)
            {
                return NotFound("Address not found.");
            }
            return Ok(address);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] AddressDto addressDto)
        {
            var address = new Address
            {
                City = addressDto.City,
                Street = addressDto.Street,
                BuildingNo = addressDto.BuildingNo
            };

            var newAddress = await addressService.CreateAsync(address);
            return CreatedAtAction(nameof(GetAddressById), new { id = newAddress.Id }, newAddress);
        }

        [HttpPut("{addressId}")]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] AddressDto addressDto, CancellationToken token)
        {
            var existingAddress = await addressService.GetAddressAsync(id, token);
            
            if (existingAddress == null)
            {
                return NotFound("Address not found.");
            }

            var updatedAddress = await addressService.UpdateAsync(existingAddress);
            
            return Ok(updatedAddress);
        }

        [HttpDelete("{addressId}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var result = await addressService.DeleteAsync(id);
            if (!result)
            {
                return NotFound("Address not found.");
            }

            return Ok($"Address {id} deleted");
        }
    }
}