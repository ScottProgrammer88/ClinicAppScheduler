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
using Microsoft.EntityFrameworkCore;

namespace ClinicAppScheduler
{
    public partial class FrmHistory : Form
    {
        // Property to store the ID of the currently logged-in patient
        public int CurrentPatientId { get; set; }

        public FrmHistory(int patientId)
        {
            InitializeComponent();
            CurrentPatientId = patientId;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (var context = new ClinicContext())
            {
                // Fetching all appointments along with related patient and doctor data
                var appointments = context.Appointments
                                          .Include(a => a.Patient)
                                          .Include(a => a.Doctor)
                                          .Where(a => a.PatientId == CurrentPatientId) // Filter by logged-in patient
                                          .ToList();

                // Creating a list of view models to display in the DataGridView
                var appointmentList = appointments.Select(appointment => new AppointmentViewModel
                {
                    AppointmentId = appointment.AppointmentId,
                    AppointmentDate = appointment.AppointmentDate,
                    AppointmentTime = appointment.AppointmentTime,
                    PatientName = $"{appointment.Patient.FirstName} {appointment.Patient.LastName}",
                    DoctorName = appointment.Doctor.FullName
                }).ToList();

                // Binding the list to the DataGridView
                dgvAppointments.DataSource = appointmentList;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointmentsForm appointment = new FrmAppointmentsForm();
            appointment.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManage manage = new FrmManage();
            manage.Show();
            this.Hide();
        }
    }
}
