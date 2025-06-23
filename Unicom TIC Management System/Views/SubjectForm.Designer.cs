namespace Unicom_TIC_Management_System.Views
{
    partial class SubjectForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSubjectName = new Label();
            txtSubjectName = new TextBox();
            lblCourseName = new Label();
            cmbCourseName = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewSubjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(30, 30);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(95, 16);
            lblSubjectName.TabIndex = 0;
            lblSubjectName.Text = "Subject Name:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(130, 27);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(200, 22);
            txtSubjectName.TabIndex = 1;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(30, 70);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(93, 16);
            lblCourseName.TabIndex = 2;
            lblCourseName.Text = "Course Name:";
            // 
            // cmbCourseName
            // 
            cmbCourseName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourseName.FormattingEnabled = true;
            cmbCourseName.Location = new Point(130, 67);
            cmbCourseName.Name = "cmbCourseName";
            cmbCourseName.Size = new Size(200, 24);
            cmbCourseName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(360, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 25);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(360, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 25);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Location = new Point(30, 143);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.Size = new Size(600, 250);
            dataGridViewSubjects.TabIndex = 7;
            dataGridViewSubjects.CellContentClick += dataGridViewSubjects_CellContentClick;
            // 
            // SubjectForm
            // 
            ClientSize = new Size(680, 420);
            Controls.Add(dataGridViewSubjects);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCourseName);
            Controls.Add(lblCourseName);
            Controls.Add(txtSubjectName);
            Controls.Add(lblSubjectName);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Name = "SubjectForm";
            Text = "Subject Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
