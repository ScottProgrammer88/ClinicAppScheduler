using ClinicAppScheduler.Data;
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
        private Appointment currentAppointment;


        public FrmManage()
        {
            InitializeComponent();
            userId = Session.userId;
            LoadAppointment();
            DisableControls(true);
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {
            // Ensure LoadAppointment is called here if not already called in the constructor
            // LoadAppointment();
        }

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

            cmbTime.SelectedIndex = 0;
        }

        private void LoadAppointment()
        {
            using (var context = new ClinicContext())
            {
                // Load the current appointment details
                currentAppointment = context.Appointments
                    .FirstOrDefault(a => a.PatientId == userId && a.AppointmentDate >= DateTime.Today);

                if (currentAppointment != null)
                {
                    // Set the DateTimePicker to the appointment date
                    dtpAppointmentDate.Value = currentAppointment.AppointmentDate;

                    // Populate the ComboBox with times
                    PopulateComboBox();

                    // Set the ComboBox to the appointment time
                    cmbTime.SelectedItem = currentAppointment.AppointmentTime;

                    var doctorDetails = context.Appointments
                                               .Where(a => a.PatientId == userId)
                                               .Join(context.Doctors,
                                                     appointment => appointment.DoctorId,
                                                     doctor => doctor.DoctorId,
                                                     (appointment, doctor) => new { doctor.FullName, doctor.Gender })
                                               .ToList();

                    ltbDoctors.DataSource = doctorDetails.Select(d => d.FullName).ToList();

                    var selectedDoctor = doctorDetails.FirstOrDefault();
                    if (selectedDoctor != null)
                    {
                        ltbDoctors.SelectedItem = selectedDoctor.FullName;
                        if (selectedDoctor.Gender == 'F')
                        {
                            rdbFemale.Checked = true;
                        }
                        else if (selectedDoctor.Gender == 'M')
                        {
                            rdbMale.Checked = true;
                        }
                    }
                }
                else
                {
                    // user will not be able to do anything
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
            dtpAppointmentDate.Enabled = !readOnly;
            cmbTime.Enabled = !readOnly;
            rdbFemale.Enabled = !readOnly;
            rdbMale.Enabled = !readOnly;
            btnSave.Enabled = !readOnly;
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
            FrmHistory history = new FrmHistory();
            history.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            DisableControls(false);
        }
    }
}
