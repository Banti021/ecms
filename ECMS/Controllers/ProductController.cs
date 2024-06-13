using ECMS.DTO.Product;
using ECMS.Enums;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(ProductService service): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProducts(CancellationToken token)
    {
        var products = await service.GetAllProductsAsync(token);
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id, CancellationToken token)
    {
        var product = await service.GetProductByIdAsync(id, token);
        return Ok(product);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
    {
        var product = await service.AddProductAsync(productDto);
        return Ok(product);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDto productDto)
    {
        var product = await service.UpdateProductAsync(id, productDto);
        return Ok(product);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        await service.DeleteProductAsync(id);
        return NoContent();
    }
    
    [HttpGet("category/{category}")]
    public async Task<IActionResult> GetProductsByCategory(ProductType category, CancellationToken token)
    {
        var products = await service.GetProductsByCategoryAsync(category, token);
        return Ok(products);
    }
}

