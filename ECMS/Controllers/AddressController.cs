using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

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
        public async Task<IActionResult> CreateAddress(Address address)
        {
            var newAddress = await addressService.CreateAsync(address);
            return CreatedAtAction(nameof(GetAddressById), new { id = newAddress.Id }, newAddress);
        }

        [HttpPut("{addressId}")]
        public async Task<IActionResult> UpdateAddress(int id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }

            var result = await addressService.UpdateAsync(address);
            if (!result)
            {
                return NotFound("Address not found.");
            }

            return NoContent();
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