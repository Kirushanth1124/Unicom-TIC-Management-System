namespace Unicom_TIC_Management_System.Views
{
    partial class CourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewCourses;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();

            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.Location = new System.Drawing.Point(30, 30);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(105, 19);
            this.lblCourseName.Text = "Course Name:";

            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCourseName.Location = new System.Drawing.Point(150, 27);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(300, 25);
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);

            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(470, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(560, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);

            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(650, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);

            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AllowUserToDeleteRows = false;
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(30, 80);
            this.dataGridViewCourses.MultiSelect = false;
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourses.Size = new System.Drawing.Size(695, 300);
            this.dataGridViewCourses.SelectionChanged += new System.EventHandler(this.dataGridViewCourses_SelectionChanged);

            // 
            // CourseForm
            // 
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
