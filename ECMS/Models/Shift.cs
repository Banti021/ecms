using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("shifts")]
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ShiftType { get; set; }
        
        [Required]
        public DateTime FromHour { get; set; }
        
        [Required]
        public DateTime ToHour { get; set; }
        
        public List<Employee> Employees { get; set; }
    }
}

