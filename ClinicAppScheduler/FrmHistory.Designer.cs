﻿namespace ClinicAppScheduler
{
    partial class FrmHistory
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            appointmentToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            dgvAppointments = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, appointmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(560, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 22);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem, manageToolStripMenuItem, historyToolStripMenuItem });
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new Size(90, 22);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(117, 22);
            bookToolStripMenuItem.Text = "Book";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(117, 22);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(117, 22);
            historyToolStripMenuItem.Text = "History";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(37, 56);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(511, 194);
            dgvAppointments.TabIndex = 1;
            // 
            // FrmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(dgvAppointments);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FrmHistory";
            Text = "History Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem appointmentToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private DataGridView dgvAppointments;
    }
}