using ClinicAppScheduler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppScheduler.Data
{
    internal class ClinicContext : DbContext
    {
         public ClinicContext() 
         {

         }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Database = the desired name for database
            // Server = the server we are connecting too. LocalDB is included with VS
            // Trusted_Connection - indicated that our windows account should be used
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Clinic;Trusted_Connection=True;");
        }

        // DbSet for Patients
        public DbSet<Patient> Patients { get; set; }

        // DbSet for Doctors
        public DbSet<Doctor> Doctors { get; set; }

        /// <summary>
        /// Inputting doctors to the Doctors table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    DoctorId = 1,
                    FullName = "Dr.J Smith",
                    LicenseNumber = "ABC123456",
                    EmailAddress = "smith1@yahoo.com",
                    Gender = 'F'
                },
                new Doctor
                {
                    DoctorId = 2,
                    FullName = "Dr.Robert Jones",
                    LicenseNumber = "DEF789101",
                    EmailAddress = "indianajones@gmail.com",
                    Gender = 'M'
                },
                new Doctor
                {
                    DoctorId = 3,
                    FullName = "Dr.Scarlett Johansson",
                    LicenseNumber = "GHI904710",
                    EmailAddress = "blackwidow@yahoo.com",
                    Gender = 'F'
                },
                new Doctor
                {
                    DoctorId = 4,
                    FullName = "Dr.Tony S",
                    LicenseNumber = "JKL220035",
                    EmailAddress = "ironman@comcast.com",
                    Gender = 'M'
                },
                new Doctor
                {
                    DoctorId = 5,
                    FullName = "Dr.Chloe Price",
                    LicenseNumber = "MNO010101",
                    EmailAddress = "price@yahoo.com",
                    Gender = 'F'
                },
                new Doctor
                {
                    DoctorId = 6,
                    FullName = "Dr.Mike Wasoski",
                    LicenseNumber = "PQR246810",
                    EmailAddress = "scarers@gmail.com",
                    Gender = 'M'
                }
            );
        }
                
        // DbSet for Appointments
        public DbSet<Appointment> Appointments { get; set; }
    }
}
