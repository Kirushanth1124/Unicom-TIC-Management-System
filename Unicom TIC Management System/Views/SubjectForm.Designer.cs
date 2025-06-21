namespace Unicom_TIC_Management_System.Views
{
    partial class SubjectForm
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

        private void InitializeComponent()
        {
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.SuspendLayout();

            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(30, 30);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(85, 15);
            this.lblSubjectName.TabIndex = 0;
            this.lblSubjectName.Text = "Subject Name:";

            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(130, 27);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(200, 23);
            this.txtSubjectName.TabIndex = 1;

            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(30, 70);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(81, 15);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name:";

            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(130, 67);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(200, 23);
            this.cmbCourseName.TabIndex = 3;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Subject";
            this.btnAdd.UseVisualStyleBackColor = true;

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Subject";
            this.btnUpdate.UseVisualStyleBackColor = true;

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Subject";
            this.btnDelete.UseVisualStyleBackColor = true;

            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.AllowUserToAddRows = false;
            this.dataGridViewSubjects.AllowUserToDeleteRows = false;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(30, 160);
            this.dataGridViewSubjects.MultiSelect = false;
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.ReadOnly = true;
            this.dataGridViewSubjects.RowTemplate.Height = 25;
            this.dataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(480, 200);
            this.dataGridViewSubjects.TabIndex = 7;

            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lblSubjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Management";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
    }
}
