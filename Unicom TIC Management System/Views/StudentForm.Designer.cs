namespace Unicom_TIC_Management_System.Views
{
    partial class StudentForm
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
            txtStName = new TextBox();
            txtStAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            labelName = new Label();
            labelAddress = new Label();
            labelDOB = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            cmbCourse = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStName
            // 
            txtStName.Location = new Point(149, 25);
            txtStName.Name = "txtStName";
            txtStName.Size = new Size(200, 23);
            txtStName.TabIndex = 0;
            txtStName.TextChanged += txtStName_TextChanged;
            // 
            // txtStAddress
            // 
            txtStAddress.Location = new Point(149, 109);
            txtStAddress.Name = "txtStAddress";
            txtStAddress.Size = new Size(200, 23);
            txtStAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(149, 229);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(149, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radMale.Location = new Point(149, 189);
            radMale.Name = "radMale";
            radMale.Size = new Size(56, 21);
            radMale.TabIndex = 3;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radFemale.Location = new Point(222, 189);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(71, 21);
            radFemale.TabIndex = 4;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(415, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(415, 68);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(415, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 274);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(600, 194);
            dataGridView1.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(25, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 17);
            labelName.TabIndex = 10;
            labelName.Text = "Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(25, 110);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(57, 17);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "Address";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDOB.Location = new Point(25, 156);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(36, 17);
            labelDOB.TabIndex = 12;
            labelDOB.Text = "DOB";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(25, 193);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(52, 17);
            labelGender.TabIndex = 13;
            labelGender.Text = "Gender";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(25, 230);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(101, 17);
            labelPhone.TabIndex = 14;
            labelPhone.Text = "Phone Number";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(149, 70);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 71);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 16;
            label1.Text = "Select Course";
            // 
            // StudentForm
            // 
            ClientSize = new Size(660, 480);
            Controls.Add(label1);
            Controls.Add(cmbCourse);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelDOB);
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(txtPhoneNumber);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtStAddress);
            Controls.Add(txtStName);
            Name = "StudentForm";
            Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.TextBox txtStAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComboBox cmbCourse;
        private Label label1;
    }
}
