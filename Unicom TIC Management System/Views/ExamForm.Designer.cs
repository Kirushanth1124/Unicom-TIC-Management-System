namespace Unicom_TIC_Management_System.Views
{
    partial class ExamForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtExamName = new TextBox();
            cmbSubjects = new ComboBox();
            dgvExams = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblExamName = new Label();
            lblSubject = new Label();
            lblSubjectID = new Label();
            lblExamID = new Label();
            txtExamID = new TextBox();
            txtSubjectID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(122, 28);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(176, 23);
            txtExamName.TabIndex = 0;
            // 
            // cmbSubjects
            // 
            cmbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(122, 66);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(176, 23);
            cmbSubjects.TabIndex = 1;
            // 
            // dgvExams
            // 
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Location = new Point(35, 178);
            dgvExams.Name = "dgvExams";
            dgvExams.RowHeadersWidth = 51;
            dgvExams.RowTemplate.Height = 24;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(438, 188);
            dgvExams.TabIndex = 4;
            dgvExams.CellClick += dgvExams_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(324, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Exam";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(324, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 28);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Exam";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Exam";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(35, 31);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(73, 15);
            lblExamName.TabIndex = 6;
            lblExamName.Text = "Exam Name:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(35, 68);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(49, 15);
            lblSubject.TabIndex = 7;
            lblSubject.Text = "Subject:";
            // 
            // lblSubjectID
            // 
            lblSubjectID.AutoSize = true;
            lblSubjectID.Location = new Point(35, 105);
            lblSubjectID.Name = "lblSubjectID";
            lblSubjectID.Size = new Size(60, 15);
            lblSubjectID.TabIndex = 8;
            lblSubjectID.Text = "Subject ID";
            // 
            // lblExamID
            // 
            lblExamID.AutoSize = true;
            lblExamID.Location = new Point(35, 139);
            lblExamID.Name = "lblExamID";
            lblExamID.Size = new Size(49, 15);
            lblExamID.TabIndex = 9;
            lblExamID.Text = "Exam ID";
            // 
            // txtExamID
            // 
            txtExamID.Location = new Point(122, 136);
            txtExamID.Name = "txtExamID";
            txtExamID.Size = new Size(176, 23);
            txtExamID.TabIndex = 10;
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(122, 103);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(176, 23);
            txtSubjectID.TabIndex = 11;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 378);
            Controls.Add(txtSubjectID);
            Controls.Add(txtExamID);
            Controls.Add(lblExamID);
            Controls.Add(lblSubjectID);
            Controls.Add(lblSubject);
            Controls.Add(lblExamName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvExams);
            Controls.Add(cmbSubjects);
            Controls.Add(txtExamName);
            Name = "ExamForm";
            Text = "Exam Form";
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblSubject;
        private Label lblSubjectID;
        private Label lblExamID;
        private TextBox txtExamID;
        private TextBox txtSubjectID;
    }
}
