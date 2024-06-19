using ECMS.Context;
using ECMS.DTO;
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
    public class AreaServiceTests
    {
        private readonly ApplicationContext _context;
        private readonly AreaService _service;
        private readonly IConfiguration _configuration;

        public AreaServiceTests()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationContext(options, _configuration);
            _service = new AreaService(_context);
        }

        private async Task ResetDatabaseAsync()
        {
            await _context.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();
        }

        [Fact]
        public async Task GetAreaListByFacilityIdAsync_ShouldReturnAreasForFacility()
        {
            await ResetDatabaseAsync();

            // Arrange
            var facility = new Facility { Name = "Facility 1", Description = "Test Facility" };
            _context.Facilities.Add(facility);
            await _context.SaveChangesAsync();

            var areas = new List<Area>
            {
                new Area { Name = "Area 1", Capacity = 100, Description = "Test Area 1", IsAvailable = true, FacilityId = facility.Id },
                new Area { Name = "Area 2", Capacity = 200, Description = "Test Area 2", IsAvailable = false, FacilityId = 2 }
            };
            _context.Areas.AddRange(areas);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetAreaList(facility.Id, CancellationToken.None);

            // Assert
            Assert.Single(result);
            var area = result.First();
            Assert.Equal("Area 1", area.Name);
            Assert.Equal(100, area.Capacity);
            Assert.Equal("Test Area 1", area.Description);
            Assert.True(area.IsAvailable);
        }

        // Other test methods...

        [Fact]
        public async Task GetAreaAsync_ShouldReturnCorrectArea()
        {
            await ResetDatabaseAsync();

            // Arrange
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true, FacilityId = 1 };
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetArea(area.Id, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Area 1", result.Name);
            Assert.Equal(100, result.Capacity);
            Assert.Equal("Test Area", result.Description);
            Assert.True(result.IsAvailable);
        }

        [Fact]
        public async Task GetAreaListAsync_ShouldReturnAllAreas()
        {
            await ResetDatabaseAsync();

            // Arrange
            var areas = new List<Area>
            {
                new Area { Name = "Area 1", Capacity = 100, Description = "Test Area 1", IsAvailable = true, FacilityId = 1 },
                new Area { Name = "Area 2", Capacity = 200, Description = "Test Area 2", IsAvailable = false, FacilityId = 2 }
            };
            _context.Areas.AddRange(areas);
            await _context.SaveChangesAsync();

            // Act
            var result = await _service.GetAreaList(CancellationToken.None);

            // Assert
            Assert.Contains(result, a => a.Name == "Area 1" && a.Capacity == 100 && a.Description == "Test Area 1" && a.IsAvailable == true);
            Assert.Contains(result, a => a.Name == "Area 2" && a.Capacity == 200 && a.Description == "Test Area 2" && a.IsAvailable == false);
        }

        [Fact]
        public async Task AddAreaAsync_ShouldAddNewArea()
        {
            await ResetDatabaseAsync();

            // Arrange
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true, FacilityId = 1 };

            // Act
            var result = await _service.AddArea(area);

            // Assert
            Assert.NotNull(result);
            var savedArea = await _context.Areas.LastAsync();
            Assert.NotNull(savedArea);
            Assert.Equal("Area 1", savedArea.Name);
            Assert.Equal(100, savedArea.Capacity);
            Assert.Equal("Test Area", savedArea.Description);
            Assert.True(savedArea.IsAvailable);
        }

        [Fact]
        public async Task UpdateAreaAsync_ShouldUpdateArea()
        {
            await ResetDatabaseAsync();

            // Arrange
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true, FacilityId = 1 };
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();
            area.Description = "Updated Area";

            // Act
            var result = await _service.UpdateArea(area);

            // Assert
            Assert.NotNull(result);
            var updatedArea = await _context.Areas.FirstOrDefaultAsync(a => a.Id == area.Id);
            Assert.NotNull(updatedArea);
            Assert.Equal("Updated Area", updatedArea.Description);
        }

        [Fact]
        public async Task DeleteAreaAsync_ShouldRemoveArea()
        {
            await ResetDatabaseAsync();

            // Arrange
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true, FacilityId = 1 };
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            // Act
            await _service.DeleteArea(area.Id);

            // Assert
            var deletedArea = await _context.Areas.FirstOrDefaultAsync(a => a.Id == area.Id);
            Assert.Null(deletedArea);
        }

        [Fact]
        public async Task GetAreaAvailabilityAsync_ShouldReturnCorrectAvailability()
        {
            await ResetDatabaseAsync();

            // Arrange
            var area = new Area { Name = "Area 1", Capacity = 100, Description = "Test Area", IsAvailable = true, FacilityId = 1 };
            _context.Areas.Add(area);
            await _context.SaveChangesAsync();

            // Act
            var availability = await _service.GetAreaAvailability(area.Id, CancellationToken.None);

            // Assert
            Assert.True(availability);
        }
    }
}
