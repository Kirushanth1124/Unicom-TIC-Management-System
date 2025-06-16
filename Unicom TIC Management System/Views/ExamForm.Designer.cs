
namespace Unicom_TIC_Management_System.Views
{
    partial class ExamForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvExams;
        private EventHandler ExamForm_Load;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblExamName = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvExams = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();

            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(30, 25);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(70, 13);
            this.lblExamName.Text = "Exam Name:";

            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(110, 22);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(200, 20);

            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(30, 60);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.Text = "Subject:";

            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.Location = new System.Drawing.Point(110, 57);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(200, 21);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(330, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler((s, e) => ClearForm());

            // 
            // dgvExams
            // 
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Location = new System.Drawing.Point(30, 100);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.Size = new System.Drawing.Size(465, 250);
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellClick);

            // 
            // ExamForm
            // 
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.lblExamName);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvExams);
            this.Name = "ExamForm";
            this.Text = "Exam Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
