using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.DTO;

public class EmployeeDto : PersonDto
{
    public string Position { get; set; }
    public Decimal Salary { get; set; }
    public DateOnly HireDate { get; set; }
    public int? SupervisorId { get; set; }
    public int? DepartmentId { get; set; }
    public int ShiftId { get; set; }
    public int AreaId { get; set; }
}
