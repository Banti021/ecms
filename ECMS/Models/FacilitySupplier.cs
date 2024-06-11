using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("facility_suppliers")]
    public class FacilitySupplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FacilityId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [ForeignKey("FacilityId")]
        public Facility Facility { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}