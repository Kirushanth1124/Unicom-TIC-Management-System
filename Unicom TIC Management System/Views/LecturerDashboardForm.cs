﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System.Views
{
    public partial class LecturerDashboardForm : Form
    {
        public LecturerDashboardForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            var timetableForm = new TimetableForm();
            timetableForm.ShowDialog();
        }

        private void btnViewExams_Click(object sender, EventArgs e)
        {
            var examForm = new ExamForm();
            examForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnViewTimetable_Click_1(object sender, EventArgs e)
        {
            var timetableForm = new TimetableForm();
            timetableForm.ShowDialog();
        }

        private void btnViewExams_Click_1(object sender, EventArgs e)
        {
            var examForm = new ExamForm();
            examForm.ShowDialog();
        }

        private void groupActions_Enter(object sender, EventArgs e)
        {

        }

        private void LecturerDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}