using ClinicAppScheduler.Data;
using ClinicAppScheduler.Migrations;
using ClinicAppScheduler.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppScheduler
{
    public partial class FrmManage : Form
    {
        private int userId;


        public FrmManage()
        {
            InitializeComponent();
            userId = Session.userId;
            LoadAppointment();
            DisableControls(true);
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populates combo box with times
        /// </summary>
        private void PopulateComboBox()
        {
            cmbTime.Items.Add("09:00 AM");
            cmbTime.Items.Add("10:00 AM");
            cmbTime.Items.Add("11:00 AM");
            cmbTime.Items.Add("12:00 PM");
            cmbTime.Items.Add("1:00 PM");
            cmbTime.Items.Add("02:00 PM");
            cmbTime.Items.Add("03:00 PM");
            cmbTime.Items.Add("04:00 PM");
            cmbTime.Items.Add("05:00 PM");
        }

        /// <summary>
        /// Retrieves appointment details that was scheduled and is shown in 
        /// list box, date time box, and time box
        /// </summary>
        private void LoadAppointment()
        {
            using (var context = new ClinicContext())
            {
                // Load the current appointment details
                var currentAppointment = context.Appointments
                    .FirstOrDefault(a => a.PatientId == userId && a.AppointmentDate >= DateTime.Today);

                if (currentAppointment != null)
                {
                    // Set the DateTimePicker to the appointment date
                    dtpAppointmentDate.Value = currentAppointment.AppointmentDate;

                    // Populate the ComboBox with times
                    PopulateComboBox();

                    // Set the ComboBox to the appointment time
                    cmbTime.SelectedItem = currentAppointment.AppointmentTime;

                    // Retrieve the details of the doctor associated with the current appointment
                    var doctorDetails = context.Doctors
                                               .Where(d => d.DoctorId == currentAppointment.DoctorId)
                                               .Select(d => new { d.FullName, d.Gender })
                                               .FirstOrDefault();

                    if (doctorDetails != null)
                    {
                        // Label shows the doctors name
                        label1.Text += " " + doctorDetails.FullName;

                        // Checks off radio button of the doctors gender
                        if (doctorDetails.Gender == 'F')
                        {
                            rdbFemale.Checked = true;
                        }
                        else if (doctorDetails.Gender == 'M')
                        {
                            rdbMale.Checked = true;
                        }
                    }
                }
                else
                {
                    // User will not be able to do anything
                    MessageBox.Show("No upcoming appointments found.");
                    DisableControls(true);
                    btnCancel.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Disables controls so user can not interact with appointment
        /// </summary>
        /// <param name="readOnly"></param>
        private void DisableControls(bool readOnly)
        {
            ltbDoctors.Enabled = !readOnly;
            dtpAppointmentDate.Enabled = !readOnly;
            cmbTime.Enabled = !readOnly;
            rdbFemale.Enabled = !readOnly;
            rdbMale.Enabled = !readOnly;
            btnSave.Enabled = !readOnly;
        }

        /// <summary>
        /// User can now change their appointment details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Choose a Doctor";
            DisableControls(false); 
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;

            // Set range on date time picker
            dtpAppointmentDate.MinDate = DateTime.Today.AddDays(1);
            dtpAppointmentDate.MaxDate = DateTime.MaxValue;
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

            // Query to get full names of the doctors who's gender is either female or male
            var doctors = dbContext.Doctors
                                   .Where(d => d.Gender == gender)
                                   .Select(d => d.FullName)
                                   .ToList();

            // Inserts doctors names into list box 
            ltbDoctors.DataSource = doctors;
        }

        /// <summary>
        /// Deletes users appointment from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            using ClinicContext context = new ClinicContext();

            // Retrieves users appointment
            var currentAppointment = context.Appointments
                    .FirstOrDefault(a => a.PatientId == userId && a.AppointmentDate >= DateTime.Today);

            // If appointment is found then remove from database
            if (currentAppointment != null)
            {
                context.Appointments.Remove(currentAppointment);
                context.SaveChanges();
                MessageBox.Show("Appointment canceled successfully.");
                FrmMenu menu = new FrmMenu();
                menu.Show(this);
                this.Hide();

            }
        }

        /// <summary>
        /// Calls method UpdateAppointmentDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateAppointmentDetails();
        }

        /// <summary>
        /// Updates the old appointment with the new appointment details
        /// </summary>
        private void UpdateAppointmentDetails()
        {
            using ClinicContext context = new ClinicContext();

            var currentAppointment = context.Appointments
                   .FirstOrDefault(a => a.PatientId == userId && a.AppointmentDate >= DateTime.Today);

            if (currentAppointment != null)
            {
                // Update the appointment date and time
                currentAppointment.AppointmentDate = dtpAppointmentDate.Value;
                currentAppointment.AppointmentTime = cmbTime.SelectedItem.ToString();

                // Gets selected doctor name from list box
                string doctorName = ltbDoctors.SelectedItem.ToString();

                // Gets selected doctor names id
                int doctorId = GetDoctorId(doctorName);
                
                currentAppointment.DoctorId = doctorId;

                // Save changes to the database
                context.SaveChanges();
                MessageBox.Show("Appointment updated successfully.");
                // Send user back to menu
                FrmMenu menu = new FrmMenu();
                menu.Show(this);
                this.Hide();
            }
        }

        /// <summary>
        /// Finds the doctors name in the database that matches the one selected in the list box.
        /// Then grabs the id of the doctor and returns the doctors id to
        /// later be saved to the database
        /// </summary>
        /// <param name="doctorName">The name selected in the combo box</param>
        /// <returns>The id of the doctor selected</returns>
        private int GetDoctorId(string? doctorName)
        {
            using ClinicContext dbContext = new ClinicContext();

            // Retrieves doctors id from database
            var doctorId = dbContext.Doctors
                                    .Where(d => d.FullName == doctorName)
                                    .Select(d => d.DoctorId)
                                    .FirstOrDefault();
            return doctorId;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show(this);
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointmentsForm appointments = new FrmAppointmentsForm();
            appointments.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistory history = new FrmHistory(userId);
            history.Show();
            this.Hide();
        }
    }
}
