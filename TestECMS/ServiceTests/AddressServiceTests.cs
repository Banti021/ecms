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
    public class AddressServiceTests
    {
        private readonly ApplicationContext _context;
        private readonly AddressService _service;
        private readonly IConfiguration _configuration;

        public AddressServiceTests()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationContext(options, _configuration);
            _service = new AddressService(_context);
        }

        private async Task ResetDatabaseAsync()
        {
            await _context.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();
        }

        [Fact]
        public async Task GetAddressesAsync_ShouldReturnAllAddresses()
        {
            await ResetDatabaseAsync();

            // Arrange
            var addresses = new List<Address>
            {
                new Address { Street = "Street 1", City = "City 1", BuildingNo = "1"},
                new Address { Street = "Street 2", City = "City 2" , BuildingNo = "2"}
            };
            _context.Addresses.AddRange(addresses);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetAddressesAsync(CancellationToken.None);
            
            Assert.Contains(result, a => a.Street == "Street 1" && a.City == "City 1" && a.BuildingNo == "1");
            Assert.Contains(result, a => a.Street == "Street 2" && a.City == "City 2" && a.BuildingNo == "2");
        }

        [Fact]
        public async Task GetAddressAsync_ShouldReturnCorrectAddress()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetAddressAsync(address.Id, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Street 1", result.Street);
            Assert.Equal("City 1", result.City);
            Assert.Equal("1", result.BuildingNo);
        }

        [Fact]
        public async Task CreateAsync_ShouldAddNewAddress()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1"};

            // Act
            var result = await _service.CreateAsync(address);

            // Assert
            Assert.NotNull(result);
            var savedAddress = await _context.Addresses.LastAsync();
            Assert.NotNull(savedAddress);
            Assert.Equal("Street 1", savedAddress.Street);
            Assert.Equal("City 1", savedAddress.City);
            Assert.Equal("1", savedAddress.BuildingNo);
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateAddress()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            address.City = "Updated City";

            // Act
            var result = await _service.UpdateAsync(address);

            // Assert
            Assert.NotNull(result);
            var updatedAddress = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == address.Id);
            Assert.NotNull(updatedAddress);
            Assert.Equal("Updated City", updatedAddress.City);
        }

        [Fact]
        public async Task DeleteAsync_ShouldRemoveAddress()
        {
            await ResetDatabaseAsync();

            // Arrange
            var address = new Address { Street = "Street 1", City = "City 1", BuildingNo = "1" };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.DeleteAsync(address.Id);

            // Assert
            Assert.True(result);
            var deletedAddress = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == address.Id);
            Assert.Null(deletedAddress);
        }
    }
}
