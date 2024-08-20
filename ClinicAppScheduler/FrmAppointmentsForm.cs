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
            LoadList(null);
        }

        /// <summary>
        /// Checks if female radio button is selected, if selected
        /// this will display the doctors who are female in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            LoadList('F');
        }

        /// <summary>
        /// Checks if male radio button is selected, if selected
        /// this will display the doctors who are male in the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            LoadList('M');
        }

        /// <summary>
        /// Displays the list of doctors from the database
        /// </summary>
        private void LoadList(char? gender)
        {
            using ClinicContext dbContext = new ClinicContext();

            // query to get full names of the doctors who's gender is either female or male
            var doctors = dbContext.Doctors
                                   .Where(d => d.Gender == gender)
                                   .Select(d => d.FullName)
                                   .ToList();

            // inserts doctors names into list box 
            ltbDoctors.DataSource = doctors;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect the data from the form
            DateTime appointmentDate = dtpAppointmentDate.Value;
            string appointmentTime = dtpAppointmentTime.Value.ToString("HH:mm");

            // gets the name of the doctor that has been selected
            String doctorName = ltbDoctors.SelectedItem.ToString();
            // gets the doctorId of the doctor selected
            int doctorId = GetDoctorId(doctorName);

            // Get the logged-in user's ID from the Session class
            int userId = Session.userId;

            // Validate doctor Id
            if (doctorId <= 0)
            {
                MessageBox.Show("Please select a doctor");
            }
            

            // Save the appointment to the database
            using (var context = new ClinicContext())  // Create a new instance of the ClinicContext
            {
                // Create a new instance of the Appointment class
                Appointment newAppointment = new Appointment
                {
                    PatientId = userId, // Associate the appointment with the logged-in user
                    DoctorId = doctorId,
                    AppointmentDate = appointmentDate,
                    AppointmentTime = appointmentTime,

                };

                // Add the new appointment to the database
                context.Appointments.Add(newAppointment);  // Add the new appointment to the Appointments DbSet
                context.SaveChanges();  // Save the changes to the database

                // Display a success message
                MessageBox.Show("Appointment saved successfully!");
                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Finds the doctors name in the database that matches the one selected in the list box.
        /// Then grabs the id of the doctor and returns the doctors id to
        /// later be saved to the database
        /// </summary>
        /// <param name="doctorName"></param>
        /// <returns>the id of the doctor selected</returns>
        private int GetDoctorId(string? doctorName)
        {
            using ClinicContext dbContext = new ClinicContext();

            var doctorId = dbContext.Doctors
                                    .Where(d => d.FullName == doctorName)
                                    .Select(d => d.DoctorId)
                                    .FirstOrDefault();
            return doctorId;
        }

        private void FrmAppointmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManage manage = new FrmManage();
            manage.Show();
            this.Hide();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistory history = new FrmHistory();
            history.Show();
            this.Hide();
        }

        
    }
}
