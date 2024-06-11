using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public String City { get; set; }
        
        [Required, StringLength(100)]
        public String Street { get; set; }
        
        [Required, StringLength(50)]
        public String BuildingNo { get; set; }
        
        public List<Facility> Facilities { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}

