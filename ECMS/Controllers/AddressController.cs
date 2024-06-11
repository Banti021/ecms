using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[Route("api/address")]
public class AddressController(AddressService addressService) : ControllerBase
{
    public readonly AddressService _addressService = addressService;

    [HttpGet]
    public async Task<IActionResult> GetAddresses(CancellationToken cancellationToken)
    {
        var addresses = await _addressService.GetAddressesAsync(cancellationToken);
        
        return Ok(addresses);
    }
    
    [HttpGet("{addressId}")]
    public async Task<IActionResult> GetAddressById(int addressId, CancellationToken cancellationToken)
    {
        var address = await _addressService.GetAddressAsync(addressId, cancellationToken);
        if (address == null)
        {
            return NotFound("Address not found.");
        }
        
        return Ok(address);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAddress(Address address)
    {
        var newAddress = await _addressService.CreateAsync(address);
        
        return CreatedAtAction(nameof(GetAddressById), new { id = newAddress.Id }, newAddress);
    }
    
    [HttpPut("{addressId}")]
    public async Task<IActionResult> UpdateAddress(int id, Address address)
    {
        if (id != address.Id)
        {
            return BadRequest();
        }
        
        await _addressService.UpdateAsync(address);
        return NoContent();
    }
    
    [HttpDelete("{addressId}")]
    public async Task<IActionResult> DeleteAddress(int id)
    {
        var result = await _addressService.DeleteAsync(id);

        if (!result)
        {
            return NotFound();
        }
        
        return Ok($"Address {id} deleted");
    }
}