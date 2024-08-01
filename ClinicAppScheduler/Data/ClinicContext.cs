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
    }
}
