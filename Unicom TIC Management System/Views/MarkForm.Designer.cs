namespace Unicom_TIC_Management_System.Views
{
    partial class MarkForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxExams;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewMarks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.comboBoxExams = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.SuspendLayout();

            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(30, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(47, 13);
            this.lblStudent.Text = "Student:";

            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(100, 27);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(200, 21);

            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(30, 65);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(37, 13);
            this.lblExam.Text = "Exam:";

            // 
            // comboBoxExams
            // 
            this.comboBoxExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExams.FormattingEnabled = true;
            this.comboBoxExams.Location = new System.Drawing.Point(100, 62);
            this.comboBoxExams.Name = "comboBoxExams";
            this.comboBoxExams.Size = new System.Drawing.Size(200, 21);

            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(30, 100);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.Text = "Score:";

            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(100, 97);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(200, 20);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "Add Mark";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.Text = "Update Mark";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(330, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.Text = "Delete Mark";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.AllowUserToAddRows = false;
            this.dataGridViewMarks.AllowUserToDeleteRows = false;
            this.dataGridViewMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(30, 150);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.ReadOnly = true;
            this.dataGridViewMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarks.Size = new System.Drawing.Size(540, 250);
            this.dataGridViewMarks.SelectionChanged += new System.EventHandler(this.dataGridViewMarks_SelectionChanged);

            // 
            // MarkForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.comboBoxExams);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewMarks);
            this.Name = "MarkForm";
            this.Text = "Mark Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
