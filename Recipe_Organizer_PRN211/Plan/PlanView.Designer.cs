using System.Windows.Forms;

namespace Recipe_Organizer_PRN211.Plan
{
    partial class PlanView
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            btnToDay = new Button();
            dtpkDate = new DateTimePicker();
            panel2 = new Panel();
            pnlMatrix = new Panel();
            panel4 = new Panel();
            btnNext = new Button();
            btnPreviours = new Button();
            btnSunday = new Button();
            btnSaturday = new Button();
            btnFriday = new Button();
            btnThusday = new Button();
            btnWednesday = new Button();
            btnTuesday = new Button();
            btnMonday = new Button();
            btnQuit = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 548);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnQuit);
            panel3.Controls.Add(btnToDay);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(4, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 43);
            panel3.TabIndex = 1;
            // 
            // btnToDay
            // 
            btnToDay.Location = new Point(657, 0);
            btnToDay.Margin = new Padding(4, 5, 4, 5);
            btnToDay.Name = "btnToDay";
            btnToDay.Size = new Size(100, 35);
            btnToDay.TabIndex = 1;
            btnToDay.Text = "Today";
            btnToDay.UseVisualStyleBackColor = true;
            btnToDay.Click += btnToDay_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(383, 5);
            dtpkDate.Margin = new Padding(4, 5, 4, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(265, 27);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlMatrix);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(4, 57);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 483);
            panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Location = new Point(117, 85);
            pnlMatrix.Margin = new Padding(4, 5, 4, 5);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(748, 391);
            pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNext);
            panel4.Controls.Add(btnPreviours);
            panel4.Controls.Add(btnSunday);
            panel4.Controls.Add(btnSaturday);
            panel4.Controls.Add(btnFriday);
            panel4.Controls.Add(btnThusday);
            panel4.Controls.Add(btnWednesday);
            panel4.Controls.Add(btnTuesday);
            panel4.Controls.Add(btnMonday);
            panel4.Location = new Point(4, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(972, 71);
            panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(868, 5);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 62);
            btnNext.TabIndex = 8;
            btnNext.Text = "▶️";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPreviours
            // 
            btnPreviours.Location = new Point(5, 5);
            btnPreviours.Margin = new Padding(4, 5, 4, 5);
            btnPreviours.Name = "btnPreviours";
            btnPreviours.Size = new Size(100, 62);
            btnPreviours.TabIndex = 7;
            btnPreviours.Text = "◀️";
            btnPreviours.UseVisualStyleBackColor = true;
            btnPreviours.Click += btnPreviours_Click;
            // 
            // btnSunday
            // 
            btnSunday.Location = new Point(761, 5);
            btnSunday.Margin = new Padding(4, 5, 4, 5);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(100, 62);
            btnSunday.TabIndex = 6;
            btnSunday.Text = "Sun";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            btnSaturday.Location = new Point(653, 5);
            btnSaturday.Margin = new Padding(4, 5, 4, 5);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(100, 62);
            btnSaturday.TabIndex = 5;
            btnSaturday.Text = "Sat";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Location = new Point(545, 5);
            btnFriday.Margin = new Padding(4, 5, 4, 5);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(100, 62);
            btnFriday.TabIndex = 4;
            btnFriday.Text = "Fri";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThusday
            // 
            btnThusday.Location = new Point(437, 5);
            btnThusday.Margin = new Padding(4, 5, 4, 5);
            btnThusday.Name = "btnThusday";
            btnThusday.Size = new Size(100, 62);
            btnThusday.TabIndex = 3;
            btnThusday.Text = "Thu";
            btnThusday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            btnWednesday.Location = new Point(329, 5);
            btnWednesday.Margin = new Padding(4, 5, 4, 5);
            btnWednesday.Name = "btnWednesday";
            btnWednesday.Size = new Size(100, 62);
            btnWednesday.TabIndex = 2;
            btnWednesday.Text = "Wed";
            btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            btnTuesday.Location = new Point(221, 5);
            btnTuesday.Margin = new Padding(4, 5, 4, 5);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(100, 62);
            btnTuesday.TabIndex = 1;
            btnTuesday.Text = "Tue";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            btnMonday.Location = new Point(113, 5);
            btnMonday.Margin = new Padding(4, 5, 4, 5);
            btnMonday.Name = "btnMonday";
            btnMonday.Size = new Size(100, 62);
            btnMonday.TabIndex = 0;
            btnMonday.Text = "Mon";
            btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(273, 1);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(78, 33);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // PlanView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 569);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PlanView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meal planning";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private Button btnQuit;
    }
}

