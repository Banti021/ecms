using ECMS.DTO;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController(CustomerService customerService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id, CancellationToken token)
        {
            var customer = await customerService.GetPersonByIdAsync(id, token);
            return Ok(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers(CancellationToken token)
        {
            var customers = await customerService.GetAllPersonsAsync(token);
            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDto customerDto)
        {
            var customer = await customerService.AddPersonAsync(customerDto);
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] CustomerDto customerDto)
        {
            var customer = await customerService.UpdatePersonAsync(id, customerDto);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await customerService.DeletePersonAsync(id);
            return NoContent();
        }
    }
}