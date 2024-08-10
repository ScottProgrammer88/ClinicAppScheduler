using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppScheduler.Data;
using ClinicAppScheduler.Models;

namespace ClinicAppScheduler
{
    public partial class FrmAppointmentsForm : Form
    {
        public FrmAppointmentsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect the data from the form
            int patientId = Convert.ToInt32(txtPatientID.Text);
            int doctorId = Convert.ToInt32(txtDoctorID.Text);
            DateTime appointmentDate = dtpAppointmentDate.Value;
            string appointmentTime = dtpAppointmentTime.Value.ToString("HH:mm");


            // Validate the patient and doctor IDs
            if (patientId <= 0 || doctorId <= 0)
            {
                MessageBox.Show("Please enter valid patient and doctor ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtDoctorID.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Save the appointment to the database
            using (var context = new ClinicContext())  // Create a new instance of the ClinicContext
            {
                // Create a new instance of the Appointment class
                Appointment newAppointment = new Appointment
                {
                    PatientId = patientId,
                    DoctorId = doctorId,
                    AppointmentDate = appointmentDate,
                    AppointmentTime = appointmentTime   
                };

                // Add the new appointment to the database
                context.Appointments.Add(newAppointment);  // Add the new appointment to the Appointments DbSet
                context.SaveChanges();  // Save the changes to the database

                // Display a success message
                MessageBox.Show("Appointment saved successfully!");
            }
        }

        private void FrmAppointmentsForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
