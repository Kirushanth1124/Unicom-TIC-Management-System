namespace Unicom_TIC_Management_System.Views
{
    partial class ViewMarksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMarks;

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
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 29;
            this.dataGridViewMarks.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewMarks.TabIndex = 0;
            // 
            // ViewMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMarks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewMarksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Marks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
