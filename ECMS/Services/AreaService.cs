using ECMS.Context;
using ECMS.DTO;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class AreaService
{
    private readonly ApplicationContext _context;
    
    public AreaService(ApplicationContext context)
    {
        _context = context;
    }
    
    public async Task<Area?> GetArea(int id, CancellationToken token)
    {
        return await _context.Areas.FindAsync(new object[] { id }, token);
    }
    
    public async Task<List<Area?>> GetAreaList(CancellationToken token)
    {
        return await _context.Areas.ToListAsync(token);
    }
    
    public async Task<List<AreaResponseDto>> GetAreaList(int facilityId, CancellationToken token)
    {
        var facility = await _context.Facilities.FindAsync(facilityId);
        
        if (facility == null)
        {
            return null;
        }

        return await _context.Areas
            .Where(a => a.FacilityId == facilityId)
            .Select(a => new AreaResponseDto
            {
                Id = a.Id,
                Name = a.Name,
                Capacity = a.Capacity,
                Description = a.Description,
                IsAvailable = a.IsAvailable
            })
            .ToListAsync(token);
    }
    
    public async Task<Area?> AddArea(Area? area)
    {
        _context.Areas.Add(area);
        await _context.SaveChangesAsync();
        return area;
    }
    
    public async Task<Area?> UpdateArea(Area? area)
    {
        _context.Areas.Update(area);
        await _context.SaveChangesAsync();
        return area;
    }
    
    public async Task DeleteArea(int id)
    {
        var area = await _context.Areas.FindAsync(new object[] { id });
        if (area != null)
        {
            _context.Areas.Remove(area);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> GetAreaAvailability(int areaId, CancellationToken token)
    {
        var area = await _context.Areas.FindAsync(new object[] { areaId }, token);
        return area?.IsAvailable ?? false;
    }

}