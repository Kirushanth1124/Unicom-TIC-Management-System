using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Views
{
    public partial class StudentDashboardForm : Form
    {
        private readonly string _studentName;
        private readonly int _studentId;

        public StudentDashboardForm(int studentId, string studentName)
        {
            InitializeComponent();
            _studentId = studentId;
            _studentName = studentName;
            

            btnViewMarks.Click += BtnViewMarks_Click;
            btnViewTimetable.Click += BtnViewTimetable_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        public StudentDashboardForm()
        {
        }

        private void BtnViewMarks_Click(object sender, EventArgs e)
        {
            try
            {
                var marks = DatabaseManager.Instance.GetStudentMarks(_studentId);
                dgvData.DataSource = marks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading marks: {ex.Message}");
            }
        }

        private void BtnViewTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                var timetable = DatabaseManager.Instance.GetStudentTimetable(_studentId);
                dgvData.DataSource = timetable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading timetable: {ex.Message}");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
