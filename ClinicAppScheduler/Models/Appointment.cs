using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppScheduler.Models
{
    public class Appointment
    {
        // Primary key for the Appointment table
        [Key]
        public int AppointmentId { get; set; }

        // Date of the Appointment
        [Required]
        public DateTime AppointmentDate { get; set; }

        // Time of the Appointment
        [Required]
        public string AppointmentTime { get; set; }

        // Foreign key referencing the Patient table
        [Required]
        public int PatientId { get; set; }

        // Foreign key referencing the Doctor table
        [Required]
        public int DoctorId { get; set; }

        /// <summary>
        /// Navigation property for the Patient table. This allows EF Core to
        /// use the PatientId to create a relationship between the Appointment and Patient tables
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Navigation property for the Doctor table. This allows EF Core to
        /// use the DoctorId to create a relationship between the Appointment and Doctor tables
        /// </summary>
        public Doctor Doctor { get; set; }
    }
}
