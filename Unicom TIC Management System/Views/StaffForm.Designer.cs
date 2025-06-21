namespace Unicom_TIC_Management_System
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView staffDataGridView;

        private void InitializeComponent()
        {
            lblStaffId = new Label();
            txtStaffId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            staffDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblStaffId
            // 
            lblStaffId.Location = new Point(20, 20);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(100, 23);
            lblStaffId.TabIndex = 0;
            lblStaffId.Text = "Staff ID:";
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(177, 17);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(100, 23);
            txtStaffId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(177, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Location = new Point(20, 140);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 23);
            lblPhoneNumber.TabIndex = 6;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(177, 137);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(220, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // staffDataGridView
            // 
            staffDataGridView.Location = new Point(20, 230);
            staffDataGridView.Name = "staffDataGridView";
            staffDataGridView.Size = new Size(500, 200);
            staffDataGridView.TabIndex = 11;
            staffDataGridView.RowHeaderMouseClick += staffDataGridView_RowHeaderMouseClick;
            // 
            // StaffForm
            // 
            ClientSize = new Size(550, 450);
            Controls.Add(lblStaffId);
            Controls.Add(txtStaffId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(staffDataGridView);
            Name = "StaffForm";
            Text = "Staff Management";
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
