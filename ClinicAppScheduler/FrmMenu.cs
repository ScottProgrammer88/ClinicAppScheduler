using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppScheduler.Migrations;
using ClinicAppScheduler.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace ClinicAppScheduler
{
    /// <summary>
    /// This is the menu form where the user can navigate through
    /// a few other forms to book appointment, cancel/update, or appointment history
    /// </summary>
    public partial class FrmMenu : Form
    {
        private int userId;

        public FrmMenu()
        {
            InitializeComponent();
            userId = Session.UserId;
        }

        /// <summary>
        /// This tab navigates to the appointment form so user
        /// can schedule appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointmentsForm appointment = new FrmAppointmentsForm();
            appointment.Show();
            this.Hide();
        }

        /// <summary>
        /// This tab navigates to the manage form so the user can
        /// cancel or update their appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManage manage = new FrmManage();
            manage.Show();
            this.Hide();
        }

        /// <summary>
        /// This tab navigates to the history form so the user
        /// can look at past or future appointments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistory history = new FrmHistory(userId);
            history.Show();
            this.Hide();
        }

        /// <summary>
        /// This button allows user to logout of their account
        /// closing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton(object sender, EventArgs e)
        {
            MessageBox.Show("Logout successful");
            Application.Exit();
        }

    }
}
