using ECMS.Context;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class AddressService(ApplicationContext context)
{
    private readonly ApplicationContext _context = context;

    public async Task<List<Address?>> GetAddressesAsync(CancellationToken cancellationToken)
    {
        return await _context.Addresses.ToListAsync(cancellationToken);
    }
    
    public async Task<Address?> GetAddressAsync(int addressId, CancellationToken cancellationToken)
    {
        return await _context.Addresses.FindAsync(new object[] { addressId }, cancellationToken);
    }

    public async Task<Address> CreateAsync(Address address)
    {
        _context.Addresses.Add(address);
        await _context.SaveChangesAsync();
        return address;
    }
    
    public async Task<bool> UpdateAsync(Address address)
    {
        _context.Addresses.Update(address);
        return await _context.SaveChangesAsync() > 0;
    }
    
    public async Task<bool> DeleteAsync(int addressId)
    {
        var address = await _context.Addresses.FindAsync(new object[] { addressId });
        if (address == null)
        {
            return false;
        }
        
        _context.Addresses.Remove(address);
        return await _context.SaveChangesAsync() > 0;
    }
}