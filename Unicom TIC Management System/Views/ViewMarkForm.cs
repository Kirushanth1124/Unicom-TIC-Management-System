using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ViewMarksForm : Form
    {
        private readonly MarkController _controller = new MarkController();

        public ViewMarksForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadMarkData();

            dataGridViewMarks.ReadOnly = true;
            dataGridViewMarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMarks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadMarkData()
        {
            try
            {
                var marks = _controller.GetAllMarksWithNames();
                dataGridViewMarks.DataSource = marks;

                dataGridViewMarks.Columns["MarkID"].HeaderText = "Mark ID";
                dataGridViewMarks.Columns["StudentName"].HeaderText = "Student";
                dataGridViewMarks.Columns["SubjectName"].HeaderText = "Subject";
                dataGridViewMarks.Columns["Score"].HeaderText = "Score";

                // Optional hide IDs
                if (dataGridViewMarks.Columns["StudentID"] != null)
                    dataGridViewMarks.Columns["StudentID"].Visible = false;
                if (dataGridViewMarks.Columns["SubjectID"] != null)
                    dataGridViewMarks.Columns["SubjectID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading marks: " + ex.Message);
            }
        }
    }
}
