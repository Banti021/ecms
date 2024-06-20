using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using ECMS.Seeders;

namespace ECMS.Context
{
    public class ApplicationContext : DbContext
    {
        private readonly bool _shouldSeedData;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IConfiguration configuration) : base(options)
        {
            _shouldSeedData = configuration.GetValue<bool>("SeedDatabase");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaEvent> AreaEvents { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCustomer> EventCustomers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilitySupplier> FacilitySuppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationArea> ReservationAreas { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Employee)
                .WithOne(e => e.Person)
                .HasForeignKey<Employee>(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.Customer)
                .WithOne(c => c.Person)
                .HasForeignKey<Customer>(c => c.PersonId);

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            });
            
            // Konfiguracja relacji Facility - Areas z kaskadowym usuwaniem (Kompozycja)
            modelBuilder.Entity<Facility>()
                .HasMany(f => f.Areas)
                .WithOne(a => a.Facility)
                .HasForeignKey(a => a.FacilityId)
                .OnDelete(DeleteBehavior.Cascade);

            // Konfiguracja innych relacji
            modelBuilder.Entity<Area>()
                .HasMany(a => a.Employees)
                .WithOne()
                .HasForeignKey(e => e.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Area>()
                .HasMany(a => a.ReservationAreas)
                .WithOne()
                .HasForeignKey(ra => ra.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Area>()
                .HasMany(a => a.AreaEvents)
                .WithOne()
                .HasForeignKey(ae => ae.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FacilitySupplier>()
                .HasOne(fs => fs.Facility)
                .WithMany(f => f.FacilitySuppliers)
                .HasForeignKey(fs => fs.FacilityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FacilitySupplier>()
                .HasOne(fs => fs.Supplier)
                .WithMany(s => s.FacilitySuppliers)
                .HasForeignKey(fs => fs.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            if (_shouldSeedData)
            {
                AddressSeeder.Seed(modelBuilder);
                EventSeeder.Seed(modelBuilder);
                FacilitySeeder.Seed(modelBuilder);
                AreaSeeder.Seed(modelBuilder);
                ShiftSeeder.Seed(modelBuilder);
                DepartmentSeeder.Seed(modelBuilder);
            }
        }
    }
}
