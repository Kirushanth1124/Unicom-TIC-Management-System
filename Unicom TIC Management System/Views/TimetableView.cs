using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;  // TimetableController namespace
using Unicom_TIC_Management_System.Modals; // Timetable model namespace

namespace Unicom_TIC_Management_System
{
    public partial class TimetableView : Form
    {
        private TimeTableController timetableController;

        public TimetableView()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\B.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            timetableController = new TimeTableController();
        }

        private void StudentTimetableForm_Load(object sender, EventArgs e)
        {
            LoadTimetable();
        }

        private void LoadTimetable()
        {
            try
            {
                List<Timetable> timetableList = timetableController.GetAllTimetables();
                dataGridViewTimetable.DataSource = null;
                dataGridViewTimetable.DataSource = timetableList;


                // Optional: Customize columns
                dataGridViewTimetable.Columns["TimetableId"].HeaderText = "ID";
                dataGridViewTimetable.Columns["SubjectId"].Visible = false; // Hide if you want
                dataGridViewTimetable.Columns["RoomId"].Visible = false;
                dataGridViewTimetable.Columns["SubjectName"].HeaderText = "Subject";
                dataGridViewTimetable.Columns["TimeSlot"].HeaderText = "Time Slot";
                dataGridViewTimetable.Columns["RoomName"].HeaderText = "Room";
                dataGridViewTimetable.Columns["RoomType"].HeaderText = "Room Type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load timetable: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTimetable();
        }

        private void dataGridViewTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}