using ECMS.Context;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class SupplierService(ApplicationContext context)
{
    public async Task<Supplier> GetSupplierById(int id, CancellationToken token)
    {
        return await context.Suppliers.FindAsync(new object[] { id }, token);
    }
    
    public async Task<List<Supplier>> GetAllSuppliers(CancellationToken token)
    {
        return await context.Suppliers.ToListAsync(token);
    }
    
    public async Task<List<Product>> GetSupplierProducts(int id, CancellationToken token)
    {
        var supplier = await context.Suppliers
            .Include(s => s.SupplierProducts)
            .ThenInclude(sp => sp.Product)
            .FirstOrDefaultAsync(s => s.Id == id, token);
        
        return supplier.SupplierProducts.Select(sp => sp.Product).ToList();
    }
    
    public async Task<Supplier> AddSupplierAsync(Supplier supplier)
    {
        var newSupplier = await context.Suppliers.AddAsync(supplier);
        await context.SaveChangesAsync();
        return newSupplier.Entity;
    }
    
    public async Task<Supplier> UpdateSupplierAsync(int id, Supplier supplier)
    {
        var existingSupplier = await context.Suppliers.FindAsync(new object[] { id });
        if (existingSupplier == null) throw new Exception("Supplier not found");
        
        existingSupplier.Name = supplier.Name;
        existingSupplier.Address = supplier.Address;
        existingSupplier.PhoneNumber = supplier.PhoneNumber;
        existingSupplier.AddressId = supplier.AddressId;
        
        await context.SaveChangesAsync();
        return existingSupplier;
    }
    
    public async Task DeleteSupplierAsync(int id)
    {
        var supplier = await context.Suppliers.FindAsync(new object[] { id });
        if (supplier == null) throw new Exception("Supplier not found");
        
        context.Suppliers.Remove(supplier);
        await context.SaveChangesAsync();
    }
    
    public async Task AddProductToSupplierAsync(int supplierId, int productId)
    {
        var supplier = await context.Suppliers.FindAsync(new object[] { supplierId });
        if (supplier == null) throw new Exception("Supplier not found");
        
        var product = await context.Products.FindAsync(new object[] { productId });
        if (product == null) throw new Exception("Product not found");
        
        supplier.SupplierProducts.Add(new SupplierProduct
        {
            SupplierId = supplierId,
            ProductId = productId
        });
        
        await context.SaveChangesAsync();
    }
    
    public async Task RemoveProductFromSupplierAsync(int supplierId, int productId)
    {
        var supplier = await context.Suppliers.FindAsync(new object[] { supplierId });
        if (supplier == null) throw new Exception("Supplier not found");
        
        var product = await context.Products.FindAsync(new object[] { productId });
        if (product == null) throw new Exception("Product not found");
        
        var supplierProduct = supplier.SupplierProducts.FirstOrDefault(sp => sp.ProductId == productId);
        if (supplierProduct == null) throw new Exception("Product not found in supplier");
        
        supplier.SupplierProducts.Remove(supplierProduct);
        
        await context.SaveChangesAsync();
    }
}