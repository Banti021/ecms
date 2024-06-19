using ECMS.Context;
using ECMS.Models;
using ECMS.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TestECMS.ServiceTests
{
    public class FacilityServiceTests
    {
        private readonly ApplicationContext _context;
        private readonly FacilityService _service;
        private readonly IConfiguration _configuration;

        public FacilityServiceTests()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationContext(options, _configuration);
            _service = new FacilityService(_context);
        }

        private async Task ResetDatabaseAsync()
        {
            await _context.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();
        }

        [Fact]
        public async Task GetFacilitiesAsync_ShouldReturnAllFacilities()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facilities = new List<Facility>
            {
                new Facility { Name = "Facility 1", Description = "Test Facility 1", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } },
                new Facility { Name = "Facility 2", Description = "Test Facility 2", Address = new Address { Street = "Street 2", City = "City 2", BuildingNo = "2" } }
            };
            _context.Facilities.AddRange(facilities);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetFacilities(CancellationToken.None);

            // Assert
            Assert.Contains(result, f => f.Name == "Facility 1" && f.Description == "Test Facility 1" && f.Address.Street == "Street 1");
            Assert.Contains(result, f => f.Name == "Facility 2" && f.Description == "Test Facility 2" && f.Address.Street == "Street 2");
        }

        [Fact]
        public async Task GetFacilityAsync_ShouldReturnCorrectFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility 1", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };
            _context.Facilities.Add(facility);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetFacility(facility.Id, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Facility 1", result.Name);
            Assert.Equal("Test Facility 1", result.Description);
            Assert.Equal("Street 1", result.Address.Street);
        }

        [Fact]
        public async Task AddFacilityAsync_ShouldAddNewFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };

            // Act
            var result = await _service.AddFacility(facility);

            // Assert
            Assert.NotNull(result);
            var savedFacility = await _context.Facilities.LastAsync();
            Assert.NotNull(savedFacility);
            Assert.Equal("Facility 1", savedFacility.Name);
            Assert.Equal("Test Facility", savedFacility.Description);
            Assert.Equal("Street 1", savedFacility.Address.Street);
        }

        [Fact]
        public async Task UpdateFacilityAsync_ShouldUpdateFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };
            _context.Facilities.Add(facility);
            await _context.SaveChangesAsync();
            facility.Description = "Updated Facility";

            // Act
            var result = await _service.UpdateFacility(facility);

            // Assert
            Assert.NotNull(result);
            var updatedFacility = await _context.Facilities.FirstOrDefaultAsync(f => f.Id == facility.Id);
            Assert.NotNull(updatedFacility);
            Assert.Equal("Updated Facility", updatedFacility.Description);
        }

        [Fact]
        public async Task DeleteFacilityAsync_ShouldRemoveFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };
            _context.Facilities.Add(facility);
            await _context.SaveChangesAsync();

            // Act
            await _service.DeleteFacility(facility.Id);

            // Assert
            var deletedFacility = await _context.Facilities.FirstOrDefaultAsync(f => f.Id == facility.Id);
            Assert.Null(deletedFacility);
        }

        [Fact]
        public async Task AssignSupplierAsync_ShouldAssignSupplierToFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = address };
            var supplier = new Supplier { Name = "Supplier 1", PhoneNumber = "123456789", AddressId = address.Id };
            _context.Facilities.Add(facility);
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.AssignSupplier(facility, supplier);

            // Assert
            Assert.NotNull(result);
            var assignedSupplier = await _context.FacilitySuppliers.FirstOrDefaultAsync(fs => fs.FacilityId == facility.Id && fs.SupplierId == supplier.Id);
            Assert.NotNull(assignedSupplier);
        }

        [Fact]
        public async Task RemoveSupplierAsync_ShouldRemoveSupplierFromFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = address };
            var supplier = new Supplier { Name = "Supplier 1", PhoneNumber = "123456789", AddressId = address.Id };
            _context.Facilities.Add(facility);
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
            await _service.AssignSupplier(facility, supplier);

            // Act
            var result = await _service.RemoveSupplier(facility, supplier);

            // Assert
            Assert.NotNull(result);
            var removedSupplier = await _context.FacilitySuppliers.FirstOrDefaultAsync(fs => fs.FacilityId == facility.Id && fs.SupplierId == supplier.Id);
            Assert.Null(removedSupplier);
        }

        [Fact]
        public async Task AssignAreaAsync_ShouldAssignAreaToFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true };
            _context.Facilities.Add(facility);
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.AssignArea(facility, area);

            // Assert
            Assert.NotNull(result);
            var assignedArea = await _context.Areas.FirstOrDefaultAsync(a => a.FacilityId == facility.Id && a.Id == area.Id);
            Assert.NotNull(assignedArea);
        }

        [Fact]
        public async Task RemoveAreaAsync_ShouldRemoveAreaFromFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility", Address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" } };
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true };
            _context.Facilities.Add(facility);
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();
            await _service.AssignArea(facility, area);

            // Act
            var result = await _service.RemoveArea(facility, area);

            // Assert
            Assert.NotNull(result);
            var removedArea = await _context.Areas.FirstOrDefaultAsync(a => a.FacilityId == facility.Id && a.Id == area.Id);
            Assert.Null(removedArea);
        }
    }
}
