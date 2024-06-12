using ECMS.Context;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services
{
    public class FacilityService
    {
        private readonly ApplicationContext _context;
        
        public FacilityService(ApplicationContext context)
        {
            _context = context;
        }
        
        public async Task<List<Facility>> GetFacilities(CancellationToken token)
        {
            return await _context.Facilities
                .Include(f => f.Address)
                .ToListAsync(token);
        }

        public async Task<Facility?> GetFacility(int id, CancellationToken token)
        {
            return await _context.Facilities
                .Include(f => f.Address)
                .FirstOrDefaultAsync(f => f.Id == id, token);
        }
        
        public async Task<Facility> AddFacility(Facility facility)
        {
            _context.Facilities.Add(facility);
            await _context.SaveChangesAsync();
            return facility;
        }
        
        public async Task<Facility> UpdateFacility(Facility facility)
        {
            _context.Facilities.Update(facility);
            await _context.SaveChangesAsync();
            return facility;
        }
        
        public async Task DeleteFacility(int id)
        {
            var facility = await _context.Facilities.FindAsync(new object[] { id });
            if (facility != null)
            {
                _context.Facilities.Remove(facility);
                await _context.SaveChangesAsync();
            }
        }
        
        public async Task<Facility> AssignSupplier(Facility facility, Supplier supplier)
        {
            var facilitySupplier = new FacilitySupplier
            {
                FacilityId = facility.Id,
                SupplierId = supplier.Id
            };
            _context.FacilitySuppliers.Add(facilitySupplier);
            await _context.SaveChangesAsync();
            return facility;
        }

        public async Task<Facility> RemoveSupplier(Facility facility, Supplier supplier)
        {
            var facilitySupplier = await _context.FacilitySuppliers
                .Where(fs => fs.FacilityId == facility.Id && fs.SupplierId == supplier.Id)
                .FirstOrDefaultAsync();
            if (facilitySupplier != null)
            {
                _context.FacilitySuppliers.Remove(facilitySupplier);
                await _context.SaveChangesAsync();
            }
            return facility;
        }

        public async Task<Facility> AssignArea(Facility facility, Area area)
        {
            facility.Areas.Add(area);
            await _context.SaveChangesAsync();
            return facility;
        }
        
        public async Task<Facility> RemoveArea(Facility facility, Area area)
        {
            facility.Areas.Remove(area);
            await _context.SaveChangesAsync();
            return facility;
        }

    }
}

