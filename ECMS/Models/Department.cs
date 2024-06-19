using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("departments")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EmployeeCount { get; set; }
        
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

