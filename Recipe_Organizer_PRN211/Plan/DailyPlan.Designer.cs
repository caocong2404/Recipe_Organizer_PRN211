namespace Recipe_Organizer_PRN211.Plan
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            panel1 = new Panel();
            panel3 = new Panel();
            btnPrevioursDay = new Button();
            btnNextDay = new Button();
            dtpkDate = new DateTimePicker();
            pnlJob = new Panel();
            mnsMain = new MenuStrip();
            mnsiAddJob = new ToolStripMenuItem();
            mnsiToDay = new ToolStripMenuItem();
            btsmiQuit = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlJob);
            panel1.Location = new Point(16, 42);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 745);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPrevioursDay);
            panel3.Controls.Add(btnNextDay);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(4, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 42);
            panel3.TabIndex = 1;
            // 
            // btnPrevioursDay
            // 
            btnPrevioursDay.Location = new Point(4, 2);
            btnPrevioursDay.Margin = new Padding(4, 5, 4, 5);
            btnPrevioursDay.Name = "btnPrevioursDay";
            btnPrevioursDay.Size = new Size(100, 35);
            btnPrevioursDay.TabIndex = 3;
            btnPrevioursDay.Text = "◀️";
            btnPrevioursDay.UseVisualStyleBackColor = true;
            btnPrevioursDay.Click += btnPrevioursDay_Click;
            // 
            // btnNextDay
            // 
            btnNextDay.Location = new Point(915, 2);
            btnNextDay.Margin = new Padding(4, 5, 4, 5);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(100, 35);
            btnNextDay.TabIndex = 2;
            btnNextDay.Text = "▶️";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Click += btnNextDay_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(372, 5);
            dtpkDate.Margin = new Padding(4, 5, 4, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(265, 27);
            dtpkDate.TabIndex = 1;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // pnlJob
            // 
            pnlJob.Location = new Point(4, 49);
            pnlJob.Margin = new Padding(4, 5, 4, 5);
            pnlJob.Name = "pnlJob";
            pnlJob.Size = new Size(1019, 688);
            pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { mnsiAddJob, mnsiToDay, btsmiQuit });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Padding = new Padding(8, 3, 0, 3);
            mnsMain.Size = new Size(1043, 30);
            mnsMain.TabIndex = 1;
            mnsMain.Text = "menuStrip1";
            // 
            // mnsiAddJob
            // 
            mnsiAddJob.Name = "mnsiAddJob";
            mnsiAddJob.Size = new Size(96, 24);
            mnsiAddJob.Text = "Add recipe";
            mnsiAddJob.Click += mnsiAddJob_Click;
            // 
            // mnsiToDay
            // 
            mnsiToDay.Name = "mnsiToDay";
            mnsiToDay.Size = new Size(63, 24);
            mnsiToDay.Text = "Today";
            mnsiToDay.Click += mnsiToDay_Click;
            // 
            // btsmiQuit
            // 
            btsmiQuit.Name = "btsmiQuit";
            btsmiQuit.Size = new Size(51, 24);
            btsmiQuit.Text = "Quit";
            btsmiQuit.Click += btsmiQuit_Click;
            // 
            // DailyPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 786);
            Controls.Add(panel1);
            Controls.Add(mnsMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnsMain;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DailyPlan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Day plan";
            FormClosing += DailyPlan_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnPrevioursDay;
        private Button btnNextDay;
        private DateTimePicker dtpkDate;
        private Panel pnlJob;
        private MenuStrip mnsMain;
        private ToolStripMenuItem mnsiAddJob;
        private ToolStripMenuItem mnsiToDay;
        private ToolStripMenuItem btsmiQuit;
    }
}