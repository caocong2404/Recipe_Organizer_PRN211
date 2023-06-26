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
			panel1 = new Panel();
			panel3 = new Panel();
			btnPrevioursDay = new Button();
			btnNextDay = new Button();
			dtpkDate = new DateTimePicker();
			pnlJob = new Panel();
			mnsMain = new MenuStrip();
			mnsiAddJob = new ToolStripMenuItem();
			mnsiToDay = new ToolStripMenuItem();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			mnsMain.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(pnlJob);
			panel1.Location = new Point(14, 31);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(880, 558);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnPrevioursDay);
			panel3.Controls.Add(btnNextDay);
			panel3.Controls.Add(dtpkDate);
			panel3.Location = new Point(4, 3);
			panel3.Margin = new Padding(4, 3, 4, 3);
			panel3.Name = "panel3";
			panel3.Size = new Size(873, 31);
			panel3.TabIndex = 1;
			// 
			// btnPrevioursDay
			// 
			btnPrevioursDay.Location = new Point(4, 1);
			btnPrevioursDay.Margin = new Padding(4, 3, 4, 3);
			btnPrevioursDay.Name = "btnPrevioursDay";
			btnPrevioursDay.Size = new Size(88, 27);
			btnPrevioursDay.TabIndex = 3;
			btnPrevioursDay.Text = "◀️";
			btnPrevioursDay.UseVisualStyleBackColor = true;
			// 
			// btnNextDay
			// 
			btnNextDay.Location = new Point(782, 3);
			btnNextDay.Margin = new Padding(4, 3, 4, 3);
			btnNextDay.Name = "btnNextDay";
			btnNextDay.Size = new Size(88, 27);
			btnNextDay.TabIndex = 2;
			btnNextDay.Text = "▶️";
			btnNextDay.UseVisualStyleBackColor = true;
			// 
			// dtpkDate
			// 
			dtpkDate.Location = new Point(309, 5);
			dtpkDate.Margin = new Padding(4, 3, 4, 3);
			dtpkDate.Name = "dtpkDate";
			dtpkDate.Size = new Size(233, 23);
			dtpkDate.TabIndex = 1;
			// 
			// pnlJob
			// 
			pnlJob.Location = new Point(4, 37);
			pnlJob.Margin = new Padding(4, 3, 4, 3);
			pnlJob.Name = "pnlJob";
			pnlJob.Size = new Size(873, 516);
			pnlJob.TabIndex = 0;
			// 
			// mnsMain
			// 
			mnsMain.Items.AddRange(new ToolStripItem[] { mnsiAddJob, mnsiToDay });
			mnsMain.Location = new Point(0, 0);
			mnsMain.Name = "mnsMain";
			mnsMain.Padding = new Padding(7, 2, 0, 2);
			mnsMain.Size = new Size(904, 24);
			mnsMain.TabIndex = 1;
			mnsMain.Text = "menuStrip1";
			// 
			// mnsiAddJob
			// 
			mnsiAddJob.Name = "mnsiAddJob";
			mnsiAddJob.Size = new Size(73, 20);
			mnsiAddJob.Text = "Thêm việc";
			// 
			// mnsiToDay
			// 
			mnsiToDay.Name = "mnsiToDay";
			mnsiToDay.Size = new Size(68, 20);
			mnsiToDay.Text = "Hôm nay";
			// 
			// DailyPlan
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(904, 590);
			Controls.Add(panel1);
			Controls.Add(mnsMain);
			MainMenuStrip = mnsMain;
			Margin = new Padding(4, 3, 4, 3);
			Name = "DailyPlan";
			Text = "Lịch trong ngày";
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			mnsMain.ResumeLayout(false);
			mnsMain.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnPrevioursDay;
		private System.Windows.Forms.Button btnNextDay;
		private System.Windows.Forms.DateTimePicker dtpkDate;
		private System.Windows.Forms.Panel pnlJob;
		private System.Windows.Forms.MenuStrip mnsMain;
		private System.Windows.Forms.ToolStripMenuItem mnsiAddJob;
		private System.Windows.Forms.ToolStripMenuItem mnsiToDay;
	}
}