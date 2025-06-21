using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class TimetableForm : Form
    {
        private readonly TimeTableController _controller = new TimeTableController();

        public TimetableForm()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadSubjects();
            LoadRooms();
            LoadTimetables();

            dataGridViewTimetables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTimetables.MultiSelect = false;
            dataGridViewTimetables.ReadOnly = true;
            dataGridViewTimetables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewTimetables.SelectionChanged += DataGridViewTimetables_SelectionChanged;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void LoadSubjects()
        {
            var subjects = new List<Subject>
            {
                new Subject { SubjectID = 1, SubjectName = "Python" },
                new Subject { SubjectID = 2, SubjectName = "C#" },
                new Subject { SubjectID = 3, SubjectName = "JavaScript" },
                new Subject { SubjectID = 4, SubjectName = "C++" },
                new Subject { SubjectID = 5, SubjectName = "HTML" }
            };

            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            var rooms = new List<Room>
            {
                new Room { RoomID = 101, RoomName = "Lab 1", RoomType = "Lab" },
                new Room { RoomID = 102, RoomName = "Lab 2", RoomType = "Lab" },
                new Room { RoomID = 201, RoomName = "Hall 1", RoomType = "Hall" },
                new Room { RoomID = 202, RoomName = "Hall 2", RoomType = "Hall" }
            };

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.SelectedIndex = -1;
        }

        private void LoadTimetables()
        {
            try
            {
                var timetables = _controller.GetAllTimetables();
                dataGridViewTimetables.DataSource = timetables;

                dataGridViewTimetables.Columns["TimetableID"].HeaderText = "Timetable ID";
                dataGridViewTimetables.Columns["SubjectID"].Visible = false;
                dataGridViewTimetables.Columns["RoomID"].Visible = false;
                dataGridViewTimetables.Columns["SubjectName"].HeaderText = "Subject";
                dataGridViewTimetables.Columns["TimeSlot"].HeaderText = "Time Slot";
                dataGridViewTimetables.Columns["RoomName"].HeaderText = "Room";
                dataGridViewTimetables.Columns["RoomType"].HeaderText = "Room Type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load timetables: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var timetable = new Timetable
            {
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                TimeSlot = txtTimeSlot.Text.Trim(),
                RoomID = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            try
            {
                _controller.AddTimetable(timetable);
                MessageBox.Show("Timetable added successfully.");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Please select a timetable and fill all fields.");
                return;
            }

            int timetableId = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            var timetable = new Timetable
            {
                TimetableID = timetableId,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                TimeSlot = txtTimeSlot.Text.Trim(),
                RoomID = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            try
            {
                _controller.UpdateTimetable(timetable);
                MessageBox.Show("Timetable updated successfully.");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            int timetableId = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _controller.DeleteTimetable(timetableId);
                MessageBox.Show("Timetable deleted.");
                LoadTimetables();
                ClearInputs();
            }
        }

        private void DataGridViewTimetables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count > 0)
            {
                var row = dataGridViewTimetables.SelectedRows[0];
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value?.ToString();
                cmbRoom.SelectedValue = Convert.ToInt32(row.Cells["RoomID"].Value);
            }
        }

        private bool ValidateInputs()
        {
            if (cmbSubject.SelectedIndex < 0)
            {
                MessageBox.Show("Select a subject.");
                return false;
            }

            if (cmbRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Select a room.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                MessageBox.Show("Enter a time slot.");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            cmbSubject.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            txtTimeSlot.Clear();
        }
    }
}
