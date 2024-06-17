using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("employees")]
    public class Employee : Person
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        
        [Required, StringLength(100)]
        public string Position { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Salary { get; set; }
        
        [Required]
        public DateOnly HireDate { get; set; }
        
        [ForeignKey("Supervisor")]
        public int? SupervisorId { get; set; }
        
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        
        [ForeignKey("Shift")]
        public int ShiftId { get; set; }
        
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        
        public Person Person { get; set; }
        public Employee Supervisor { get; set; }
        public Department Department { get; set; }
        public Shift Shift { get; set; }
        public Area Area { get; set; }

        public override string GetFullName()
        {
            return $"{Person.GetFullName()} (Employee - {Position})";
        }

        public decimal CalculateAnnualBonus()
        {
            return Salary * 0.1m;
        }
    }
}