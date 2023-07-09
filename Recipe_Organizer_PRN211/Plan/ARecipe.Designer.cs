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
            btnDetail = new Button();
            btnOpenSearch = new Button();
            txbJob = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txbJob);
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 46);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(906, 6);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(827, 5);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(71, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(658, 7);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(146, 28);
            cbStatus.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDetail);
            panel2.Controls.Add(btnOpenSearch);
            panel2.Location = new Point(439, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 46);
            panel2.TabIndex = 2;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(103, 7);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnOpenSearch
            // 
            btnOpenSearch.Location = new Point(3, 6);
            btnOpenSearch.Name = "btnOpenSearch";
            btnOpenSearch.Size = new Size(94, 29);
            btnOpenSearch.TabIndex = 0;
            btnOpenSearch.Text = "Search";
            btnOpenSearch.UseVisualStyleBackColor = true;
            btnOpenSearch.Click += btnOpenSearch_Click;
            // 
            // txbJob
            // 
            txbJob.Enabled = false;
            txbJob.Location = new Point(38, 6);
            txbJob.Margin = new Padding(4, 5, 4, 5);
            txbJob.Name = "txbJob";
            txbJob.Size = new Size(372, 27);
            txbJob.TabIndex = 1;
            // 
            // ARecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ARecipe";
            Size = new Size(1004, 51);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbStatus;
        private Button btnDetail;
        private Button btnOpenSearch;
    }
}