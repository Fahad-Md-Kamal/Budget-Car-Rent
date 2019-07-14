using BudgetCarRental.Model.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetCarRental.api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {  }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<RentalArrangement> RentalArrangements { get; set; }
        public DbSet<RepairSession> RepairSessions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDescription> VehcileDescriptions { get; set; }

        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerContact> CustomerContacts { get; set; }

        public DbSet<DriverAddress> DriverAddresses { get; set; }
        public DbSet<DriverContact> DriverContacts { get; set; }
        public DbSet<DriverPayment> DriverPayments { get; set; }

        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<EmployeePhoto> EmployeePhotos { get; set; }

        public DbSet<FleetPayment> FleetPayments { get; set; }
        //public DbSet<FleetVehicle> VehicleFleets { get; set; }

        public DbSet<PartsForRepair> PartsForRepairs { get; set; }
        public DbSet<RepairingEmployee> RepairingEmployees { get; set; }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<CustomerPhoto> CustomerPhotos { get; set; }
        public DbSet<DriverPhoto> DriverPhotos { get; set; }
        public DbSet<VehiclePhoto> VehcilePhotos { get; set; }
        public DbSet<PartsPhoto> PartsPhotos { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Vehicle>()
                .HasAlternateKey(x => x.RegNo);

            #region Customer Address
            builder.Entity<CustomerAddress>()
                .HasKey(x => new { x.AddressId, x.CustomerId });

            builder.Entity<CustomerAddress>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.CustomerAddresses)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerAddress>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerAddresses)
            //    .HasForeignKey(x => x.AddressId);
            #endregion

            #region Customer Contact
            builder.Entity<CustomerContact>()
                .HasKey(x => new { x.ContactId, x.CustomerId });

            builder.Entity<CustomerContact>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.CustomerContacts)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerContact>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerContacts)
            //    .HasForeignKey(x => x.ContactId);
            #endregion

            #region Customer Photo
            builder.Entity<CustomerPhoto>()
                .HasKey(x => new { x.PhotoId, x.CustomerId });

            builder.Entity<CustomerPhoto>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.CustomerPhotos)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerPhoto>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerPhotos)
            //    .HasForeignKey(x => x.PhotoId);
            #endregion


            #region Driver Address
            builder.Entity<DriverAddress>()
                .HasKey(x => new { x.AddressId, x.DriverId });
            builder.Entity<DriverAddress>()
                .HasOne(x => x.Driver)
                .WithMany(x => x.DriverAddresses)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<DriverAddress>()
            //    .HasOne(x => x.Driver)
            //    .WithMany(x => x.DriverAddresses)
            //    .HasForeignKey(x => x.AddressId);
            #endregion

            #region Driver Contact
            builder.Entity<DriverContact>()
                .HasKey(x => new { x.ContactId, x.DriverId });
            builder.Entity<DriverContact>()
                .HasOne(x => x.Driver)
                .WithMany(x => x.DriverContacts)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerContact>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerContacts)
            //    .HasForeignKey(x => x.ContactId);
            #endregion

            #region Driver Photo
            builder.Entity<DriverPhoto>()
                .HasKey(x => new { x.PhotoId, x.DriverId });
            builder.Entity<DriverPhoto>()
                .HasOne(x => x.Driver)
                .WithMany(x => x.DriverPhotos)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerPhoto>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerPhotos)
            //    .HasForeignKey(x => x.PhotoId);
            #endregion

            #region Driver Payment
            builder.Entity<DriverPayment>()
                .HasKey(x => new { x.PaymentId, x.DriverId });
            builder.Entity<DriverPayment>()
                .HasOne(x => x.Driver)
                .WithMany(x => x.DriverPayments)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerPhoto>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerPhotos)
            //    .HasForeignKey(x => x.PhotoId);
            #endregion


            #region Employee Address
            builder.Entity<EmployeeAddress>()
                .HasKey(x => new { x.AddressId, x.EmployeeId });
            builder.Entity<EmployeeAddress>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeAddresses)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerAddress>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerAddresses)
            //    .HasForeignKey(x => x.AddressId);
            #endregion

            #region Employee Contact
            builder.Entity<EmployeeContact>()
                .HasKey(x => new { x.ContactId, x.EmployeeId });
            builder.Entity<EmployeeContact>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeContacts)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerContact>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerContacts)
            //    .HasForeignKey(x => x.ContactId);
            #endregion

            #region Employee Photo
            builder.Entity<EmployeePhoto>()
                .HasKey(x => new { x.PhotoId, x.EmployeeId });
            builder.Entity<EmployeePhoto>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeePhotos)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerPhoto>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerPhotos)
            //    .HasForeignKey(x => x.PhotoId);
            #endregion


            #region Fleet Payment
            builder.Entity<FleetPayment>()
                .HasKey(x => new { x.PaymentId, x.FleetId });
            builder.Entity<FleetPayment>()
                .HasOne(x => x.Fleet)
                .WithMany(x => x.FleetPayments)
                .HasForeignKey(x => x.FleetId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<CustomerPhoto>()
            //    .HasOne(x => x.Customer)
            //    .WithMany(x => x.CustomerPhotos)
            //    .HasForeignKey(x => x.PhotoId);
            #endregion

            #region Vehicle Fleet
            builder.Entity<VehicleFleet>()
                .HasKey(x => new { x.VehicleId, x.FleetId });

            builder.Entity<VehicleFleet>()
                .HasOne(x => x.Fleet)
                .WithMany(x => x.VehicleFleets)
                .HasForeignKey(x => x.FleetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<VehicleFleet>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.VehicleFleets)
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion


            #region Parts For Repair
            builder.Entity<PartsForRepair>()
                .HasKey(x => new { x.PartsId, x.RepairId });

            builder.Entity<PartsForRepair>()
                .HasOne(x => x.Parts)
                .WithMany(x => x.PartsForRepairs)
                .HasForeignKey(x => x.PartsId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<PartsForRepair>()
                .HasOne(x => x.RepairSession)
                .WithMany(x => x.PartsForRepairs)
                .HasForeignKey(x => x.RepairId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Repairing Employees
            builder.Entity<RepairingEmployee>()
                .HasKey(x => new { x.EmployeeId, x.RepairId });

            builder.Entity<RepairingEmployee>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.RepairingEmployees)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<RepairingEmployee>()
                .HasOne(x => x.RepairSession)
                .WithMany(x => x.RepairingEmployees)
                .HasForeignKey(x => x.RepairId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region Vehicle Photo
            builder.Entity<VehiclePhoto>()
                .HasKey(x => new { x.VehicleID, x.PhotoId });

            builder.Entity<VehiclePhoto>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.VehiclePhotos)
                .HasForeignKey(x => x.VehicleID)
                .OnDelete(DeleteBehavior.Restrict);


            //builder.Entity<VehiclePhoto>()
            //    .HasOne(x => x.RepairSession)
            //    .WithMany(x => x.RepairingEmployees)
            //    .HasForeignKey(x => x.EmployeeId);
            #endregion

            #region Parts Photo
            builder.Entity<PartsPhoto>()
                .HasKey(x => new { x.PartsId, x.PhotoId });

            builder.Entity<PartsPhoto>()
                .HasOne(x => x.Parts)
                .WithMany(x => x.PartsPhotos)
                .HasForeignKey(x => x.PartsId)
                .OnDelete(DeleteBehavior.Restrict);


            //builder.Entity<VehiclePhoto>()
            //    .HasOne(x => x.RepairSession)
            //    .WithMany(x => x.RepairingEmployees)
            //    .HasForeignKey(x => x.EmployeeId);
            #endregion

        }


    }
}