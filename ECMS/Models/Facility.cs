using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("facilities")]
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        
        [Required, StringLength(255)]
        public string Description { get; set; }
        
        [Required]
        public int Capacity { get; set; }
        
        public List<Area> Areas { get; set; }
        public List<FacilitySupplier> FacilitySuppliers { get; set; }
        public Address Address { get; set; }
    }
}

