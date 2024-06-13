using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SupplierController(SupplierService service): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetSuppliers(CancellationToken token)
    {
        var suppliers = await service.GetAllSuppliers(token);
        return Ok(suppliers);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSupplierById(int id, CancellationToken token)
    {
        var supplier = await service.GetSupplierById(id, token);
        return Ok(supplier);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddSupplier(Supplier supplier, CancellationToken token)
    {
        var newSupplier = await service.AddSupplierAsync(supplier);
        return CreatedAtAction(nameof(GetSupplierById), new { id = newSupplier.Id }, newSupplier);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSupplier(int id, Supplier supplier, CancellationToken token)
    {
        var updatedSupplier = await service.UpdateSupplierAsync(id, supplier);
        return Ok(updatedSupplier);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSupplier(int id, CancellationToken token)
    {
        await service.DeleteSupplierAsync(id);
        return NoContent();
    }
    
    [HttpPost("{supplierId}/products/{productId}")]
    public async Task<IActionResult> AddProductToSupplier(int supplierId, int productId, CancellationToken token)
    {
        await service.AddProductToSupplierAsync(supplierId, productId);
        return NoContent();
    }
    
    [HttpDelete("{supplierId}/products/{productId}")]
    public async Task<IActionResult> RemoveProductFromSupplier(int supplierId, int productId, CancellationToken token)
    {
        await service.RemoveProductFromSupplierAsync(supplierId, productId);
        return NoContent();
    }
}