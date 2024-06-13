using ECMS.Models;

namespace ECMS.DTO.Supplier
{
    public class AssignSupplierDto
    {
        public Facility FacilityId { get; set; }
        public Models.Supplier SupplierId { get; set; }
    }
}