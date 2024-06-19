using System.Threading.Tasks;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController(PersonService conversionService) : ControllerBase
    {
        [HttpPost("convertCustomerToEmployee/{customerId}")]
        public async Task<IActionResult> ConvertCustomerToEmployee(int customerId, string position, decimal salary, DateOnly hireDate, int shiftId, int areaId, int? supervisorId = null, int? departmentId = null)
        {
            try
            {
                var employee = await conversionService.ConvertCustomerToEmployee(customerId, position, salary, hireDate, shiftId, areaId, supervisorId, departmentId);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("convertEmployeeToCustomer/{employeeId}")]
        public async Task<IActionResult> ConvertEmployeeToCustomer(int employeeId, DateTime dateOfBirth, DateTime joinDate, DateTime lastVisit)
        {
            try
            {
                var customer = await conversionService.ConvertEmployeeToCustomer(employeeId, dateOfBirth, joinDate, lastVisit);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}