using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("areas")]
    public class Area
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        public int Capacity { get; set; }
        
        [Required, StringLength(255)]
        public string Description { get; set; }
        
        [Required]
        public bool IsAvailable { get; set; }
        
        [ForeignKey("Facility")]
        public int FacilityId { get; set; }
        
        public List<Employee> Employees { get; set; }
        public List<ReservationArea> ReservationAreas { get; set; }
        public List<AreaEvent> AreaEvents { get; set; }
        public Facility Facility { get; set; }
    }
}

