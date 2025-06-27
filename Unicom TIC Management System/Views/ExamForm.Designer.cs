namespace Unicom_TIC_Management_System.Views
{
    partial class ExamForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblExamID;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtExamID;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvExams;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblExamID = new Label();
            lblExamName = new Label();
            lblSubject = new Label();
            txtExamID = new TextBox();
            txtExamName = new TextBox();
            cmbSubjects = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvExams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // lblExamID
            // 
            lblExamID.AutoSize = true;
            lblExamID.Location = new Point(30, 30);
            lblExamID.Name = "lblExamID";
            lblExamID.Size = new Size(52, 15);
            lblExamID.TabIndex = 0;
            lblExamID.Text = "Exam ID:";
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(30, 70);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(73, 15);
            lblExamName.TabIndex = 2;
            lblExamName.Text = "Exam Name:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(30, 110);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(49, 15);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Subject:";
            // 
            // txtExamID
            // 
            txtExamID.Location = new Point(120, 27);
            txtExamID.Name = "txtExamID";
            txtExamID.ReadOnly = true;
            txtExamID.Size = new Size(200, 23);
            txtExamID.TabIndex = 1;
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(120, 67);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(200, 23);
            txtExamName.TabIndex = 3;
            // 
            // cmbSubjects
            // 
            cmbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(120, 107);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(200, 23);
            cmbSubjects.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Exam";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(360, 65);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Exam";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(360, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Exam";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(30, 159);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(600, 250);
            dgvExams.TabIndex = 9;
            dgvExams.CellClick += dgvExams_CellClick;
            dgvExams.CellContentClick += dgvExams_CellContentClick;
            // 
            // ExamForm
            // 
            ClientSize = new Size(680, 440);
            Controls.Add(dgvExams);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbSubjects);
            Controls.Add(lblSubject);
            Controls.Add(txtExamName);
            Controls.Add(lblExamName);
            Controls.Add(txtExamID);
            Controls.Add(lblExamID);
            Name = "ExamForm";
            Text = "Exam Management";
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
