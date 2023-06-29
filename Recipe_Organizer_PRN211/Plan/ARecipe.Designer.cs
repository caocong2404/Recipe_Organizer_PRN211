namespace Recipe_Organizer_PRN211.Plan
{
    partial class ARecipe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            cbStatus = new ComboBox();
            panel2 = new Panel();
            nmToMinute = new NumericUpDown();
            nmToHours = new NumericUpDown();
            label1 = new Label();
            nmFromMinute = new NumericUpDown();
            nmFromHours = new NumericUpDown();
            txbJob = new TextBox();
            ckbDone = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txbJob);
            panel1.Controls.Add(ckbDone);
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 46);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(932, 0);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(867, 0);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(721, 3);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(136, 28);
            cbStatus.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(nmToMinute);
            panel2.Controls.Add(nmToHours);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nmFromMinute);
            panel2.Controls.Add(nmFromHours);
            panel2.Location = new Point(451, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 46);
            panel2.TabIndex = 2;
            // 
            // nmToMinute
            // 
            nmToMinute.Location = new Point(213, 5);
            nmToMinute.Margin = new Padding(4, 5, 4, 5);
            nmToMinute.Name = "nmToMinute";
            nmToMinute.Size = new Size(49, 27);
            nmToMinute.TabIndex = 4;
            // 
            // nmToHours
            // 
            nmToHours.Location = new Point(156, 5);
            nmToHours.Margin = new Padding(4, 5, 4, 5);
            nmToHours.Name = "nmToHours";
            nmToHours.Size = new Size(49, 27);
            nmToHours.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Đến";
            // 
            // nmFromMinute
            // 
            nmFromMinute.Location = new Point(61, 5);
            nmFromMinute.Margin = new Padding(4, 5, 4, 5);
            nmFromMinute.Name = "nmFromMinute";
            nmFromMinute.Size = new Size(49, 27);
            nmFromMinute.TabIndex = 1;
            // 
            // nmFromHours
            // 
            nmFromHours.Location = new Point(4, 5);
            nmFromHours.Margin = new Padding(4, 5, 4, 5);
            nmFromHours.Name = "nmFromHours";
            nmFromHours.Size = new Size(49, 27);
            nmFromHours.TabIndex = 0;
            // 
            // txbJob
            // 
            txbJob.Location = new Point(32, 0);
            txbJob.Margin = new Padding(4, 5, 4, 5);
            txbJob.Name = "txbJob";
            txbJob.Size = new Size(409, 27);
            txbJob.TabIndex = 1;
            // 
            // ckbDone
            // 
            ckbDone.AutoSize = true;
            ckbDone.Location = new Point(4, 5);
            ckbDone.Margin = new Padding(4, 5, 4, 5);
            ckbDone.Name = "ckbDone";
            ckbDone.Size = new Size(18, 17);
            ckbDone.TabIndex = 0;
            ckbDone.UseVisualStyleBackColor = true;
            // 
            // ARecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 290);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ARecipe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmFromHours;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
    }
}