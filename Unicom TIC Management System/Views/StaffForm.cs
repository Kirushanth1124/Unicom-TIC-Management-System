using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System
{
    public partial class StaffForm : Form
    {
        private readonly StaffController _staffController;

        public StaffForm()
        {
            InitializeComponent();
            _staffController = new StaffController();
            LoadStaffData();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoadStaffData()
        {
            staffDataGridView.DataSource = null;
            staffDataGridView.DataSource = _staffController.GetAllStaff();
        }

        private void ClearFields()
        {
            txtStaffId.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = new Staff
                {
                    StaffName = txtName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim()
                };

                _staffController.AddStaff(staff);
                MessageBox.Show("Staff added successfully.");
                LoadStaffData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add Error: {ex.Message}");
            }
            if (staffDataGridView == null)
            {
                MessageBox.Show("DataGridView is not initialized");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(txtStaffId.Text);

                var staff = new Staff
                {
                    StaffId = staffId,
                    StaffName = txtName.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim()
                };

                _staffController.UpdateStaff(staff);
                MessageBox.Show("Staff updated successfully.");
                LoadStaffData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(txtStaffId.Text);
                _staffController.DeleteStaff(staffId);
                MessageBox.Show("Staff deleted successfully.");
                LoadStaffData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete Error: {ex.Message}");
            }
        }

        private void staffDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStaffId.Text = staffDataGridView.Rows[e.RowIndex].Cells["StaffId"].Value.ToString();
                txtName.Text = staffDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtPassword.Text = staffDataGridView.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtPhoneNumber.Text = staffDataGridView.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            }
        }
    }
}
