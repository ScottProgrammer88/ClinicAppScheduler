namespace ClinicAppScheduler
{
    partial class FrmAppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPatientID = new Label();
            lblDoctorID = new Label();
            lblAppointmentDate = new Label();
            txtPatientID = new TextBox();
            txtDoctorID = new TextBox();
            btnSave = new Button();
            dtpAppointmentDate = new DateTimePicker();
            lblAppointmentTime = new Label();
            dtpAppointmentTime = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            appointmentToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(139, 100);
            lblPatientID.Margin = new Padding(4, 0, 4, 0);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(88, 25);
            lblPatientID.TabIndex = 0;
            lblPatientID.Text = "Patient ID";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Location = new Point(139, 205);
            lblDoctorID.Margin = new Padding(4, 0, 4, 0);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new Size(90, 25);
            lblDoctorID.TabIndex = 1;
            lblDoctorID.Text = "Doctor ID";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(139, 310);
            lblAppointmentDate.Margin = new Padding(4, 0, 4, 0);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(160, 25);
            lblAppointmentDate.TabIndex = 2;
            lblAppointmentDate.Text = "Appointment Date";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(334, 100);
            txtPatientID.Margin = new Padding(4, 5, 4, 5);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(264, 31);
            txtPatientID.TabIndex = 3;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new Point(334, 205);
            txtDoctorID.Margin = new Padding(4, 5, 4, 5);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(264, 31);
            txtDoctorID.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(114, 540);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 77);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new Point(334, 310);
            dtpAppointmentDate.Margin = new Padding(4, 5, 4, 5);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(360, 31);
            dtpAppointmentDate.TabIndex = 9;
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new Point(139, 423);
            lblAppointmentTime.Margin = new Padding(4, 0, 4, 0);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(161, 25);
            lblAppointmentTime.TabIndex = 10;
            lblAppointmentTime.Text = "Appointment Time";
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new Point(334, 423);
            dtpAppointmentTime.Margin = new Padding(4, 5, 4, 5);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.ShowUpDown = true;
            dtpAppointmentTime.Size = new Size(360, 31);
            dtpAppointmentTime.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, appointmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem, manageToolStripMenuItem, historyToolStripMenuItem });
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new Size(134, 29);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(270, 34);
            bookToolStripMenuItem.Text = "Book";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(270, 34);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(270, 34);
            historyToolStripMenuItem.Text = "History";
            // 
            // FrmAppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dtpAppointmentTime);
            Controls.Add(lblAppointmentTime);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(btnSave);
            Controls.Add(txtDoctorID);
            Controls.Add(txtPatientID);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblDoctorID);
            Controls.Add(lblPatientID);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAppointmentsForm";
            Text = "Appointments Form";
            Load += FrmAppointmentsForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientID;
        private Label lblDoctorID;
        private Label lblAppointmentDate;
        private TextBox txtPatientID;
        private TextBox txtDoctorID;
        private Button btnSave;
        private DateTimePicker dtpAppointmentDate;
        private Label lblAppointmentTime;
        private DateTimePicker dtpAppointmentTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem appointmentToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}