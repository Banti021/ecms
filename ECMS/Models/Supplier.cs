using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("suppliers")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public String Name { get; set; }
        
        [Required, StringLength(50)]
        public String PhoneNumber { get; set; }
        
        [Required]
        public int AddressId { get; set; }
        
        public List<SupplierProduct> SupplierProducts { get; set; }
        public List<FacilitySupplier> FacilitySuppliers { get; set; }
        public Address Address { get; set; }
    }
}

