using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using ECMS.Seeders;

namespace ECMS.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

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
            
            AddressSeeder.Seed(modelBuilder);
            PersonSeeder.Seed(modelBuilder);
            CustomerSeeder.Seed(modelBuilder);
            FacilitySeeder.Seed(modelBuilder);
            AreaSeeder.Seed(modelBuilder);
            ShiftSeeder.Seed(modelBuilder);
            DepartmentSeeder.Seed(modelBuilder);
            EmployeeSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
