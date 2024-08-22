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
    public partial class FrmMenu : Form
    {
        private int userId;

        public FrmMenu()
        {
            InitializeComponent();
            userId = Session.userId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout successful");
            Application.Exit();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistory history = new FrmHistory(userId);
            history.Show();
            this.Hide();
        }
    }
}
