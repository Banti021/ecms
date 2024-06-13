using ECMS.Context;
using ECMS.DTO.Product;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class ProductService(ApplicationContext context)
{
    public async Task<List<ProductDto>> GetAllProductsAsync(CancellationToken token)
    {
        var products = await context.Products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            Stock = p.Stock
        }).ToListAsync(token);
        
        return products;
    }
    
    public async Task<ProductDto> GetProductByIdAsync(int id, CancellationToken token)
    {
        var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id, token);
        if (product == null) throw new Exception("Product not found");
        
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock
        };
    }
    
    public async Task<ProductDto> AddProductAsync(ProductDto productDto)
    {
        var product = new Product
        {
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price,
            Stock = productDto.Stock
        };
        
        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();
        
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock
        };
    }
    
    public async Task<ProductDto> UpdateProductAsync(int id, ProductDto productDto)
    {
        var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
        if (product == null) throw new Exception("Product not found");
        
        product.Name = productDto.Name;
        product.Description = productDto.Description;
        product.Price = productDto.Price;
        product.Stock = productDto.Stock;
        
        await context.SaveChangesAsync();
        
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Stock = product.Stock
        };
    }
    
    public async Task DeleteProductAsync(int id)
    {
        var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
        if (product == null) throw new Exception("Product not found");
        
        context.Products.Remove(product);
        await context.SaveChangesAsync();
    }
    
    public async Task<List<ProductDto>> GetProductsByCategoryAsync(ProductType category, CancellationToken token)
    {
        var products = await context.Products.Where(p => p.Category == category)
                                             .Select(p => new ProductDto
                                             {
                                                 Id = p.Id,
                                                 Name = p.Name,
                                                 Description = p.Description,
                                                 Price = p.Price,
                                                 Stock = p.Stock
                                             }).ToListAsync(token);
        
        return products;
    }
    
    
    
}