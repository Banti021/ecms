using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.Models
{
    [Table("shifts")]
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public ShiftType ShiftType { get; set; }
        
        [Required]
        public TimeSpan FromHour { get; set; }
        
        [Required]
        public TimeSpan ToHour { get; set; }
        
        public List<Employee> Employees { get; set; }
    }
}

