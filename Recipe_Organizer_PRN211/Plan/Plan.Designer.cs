namespace Recipe_Organizer_PRN211.Plan
{
	partial class Plan
	{
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
			panel6 = new Panel();
			nmNotify = new NumericUpDown();
			ckbNotify = new CheckBox();
			btnToDay = new Button();
			dtpkDate = new DateTimePicker();
			panel2 = new Panel();
			panel5 = new Panel();
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
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nmNotify).BeginInit();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(14, 14);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(864, 532);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(panel6);
			panel3.Controls.Add(btnToDay);
			panel3.Controls.Add(dtpkDate);
			panel3.Location = new Point(4, 3);
			panel3.Margin = new Padding(4, 3, 4, 3);
			panel3.Name = "panel3";
			panel3.Size = new Size(858, 32);
			panel3.TabIndex = 1;
			// 
			// panel6
			// 
			panel6.Controls.Add(nmNotify);
			panel6.Controls.Add(ckbNotify);
			panel6.Location = new Point(8, 0);
			panel6.Margin = new Padding(4, 3, 4, 3);
			panel6.Name = "panel6";
			panel6.Size = new Size(245, 32);
			panel6.TabIndex = 2;
			// 
			// nmNotify
			// 
			nmNotify.Location = new Point(72, 5);
			nmNotify.Margin = new Padding(4, 3, 4, 3);
			nmNotify.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
			nmNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nmNotify.Name = "nmNotify";
			nmNotify.Size = new Size(70, 23);
			nmNotify.TabIndex = 1;
			nmNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// ckbNotify
			// 
			ckbNotify.AutoSize = true;
			ckbNotify.Location = new Point(4, 5);
			ckbNotify.Margin = new Padding(4, 3, 4, 3);
			ckbNotify.Name = "ckbNotify";
			ckbNotify.Size = new Size(59, 19);
			ckbNotify.TabIndex = 0;
			ckbNotify.Text = "Notify";
			ckbNotify.UseVisualStyleBackColor = true;
			// 
			// btnToDay
			// 
			btnToDay.Location = new Point(575, 0);
			btnToDay.Margin = new Padding(4, 3, 4, 3);
			btnToDay.Name = "btnToDay";
			btnToDay.Size = new Size(88, 27);
			btnToDay.TabIndex = 1;
			btnToDay.Text = "Go";
			btnToDay.UseVisualStyleBackColor = true;
			// 
			// dtpkDate
			// 
			dtpkDate.Location = new Point(335, 3);
			dtpkDate.Margin = new Padding(4, 3, 4, 3);
			dtpkDate.Name = "dtpkDate";
			dtpkDate.Size = new Size(233, 23);
			dtpkDate.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(panel5);
			panel2.Controls.Add(panel4);
			panel2.Location = new Point(4, 43);
			panel2.Margin = new Padding(4, 3, 4, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(858, 486);
			panel2.TabIndex = 0;
			// 
			// panel5
			// 
			panel5.Location = new Point(103, 63);
			panel5.Margin = new Padding(4, 3, 4, 3);
			panel5.Name = "panel5";
			panel5.Size = new Size(654, 419);
			panel5.TabIndex = 1;
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
			panel4.Location = new Point(4, 3);
			panel4.Margin = new Padding(4, 3, 4, 3);
			panel4.Name = "panel4";
			panel4.Size = new Size(850, 53);
			panel4.TabIndex = 0;
			// 
			// btnNext
			// 
			btnNext.Location = new Point(760, 3);
			btnNext.Margin = new Padding(4, 3, 4, 3);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(88, 46);
			btnNext.TabIndex = 8;
			btnNext.Text = "▶️";
			btnNext.UseVisualStyleBackColor = true;
			// 
			// btnPreviours
			// 
			btnPreviours.Location = new Point(5, 3);
			btnPreviours.Margin = new Padding(4, 3, 4, 3);
			btnPreviours.Name = "btnPreviours";
			btnPreviours.Size = new Size(88, 46);
			btnPreviours.TabIndex = 7;
			btnPreviours.Text = "◀️";
			btnPreviours.UseVisualStyleBackColor = true;
			btnPreviours.Click += btnPreviours_Click;
			// 
			// btnSunday
			// 
			btnSunday.Location = new Point(666, 3);
			btnSunday.Margin = new Padding(4, 3, 4, 3);
			btnSunday.Name = "btnSunday";
			btnSunday.Size = new Size(88, 46);
			btnSunday.TabIndex = 6;
			btnSunday.Text = "Sunday";
			btnSunday.UseVisualStyleBackColor = true;
			// 
			// btnSaturday
			// 
			btnSaturday.Location = new Point(572, 3);
			btnSaturday.Margin = new Padding(4, 3, 4, 3);
			btnSaturday.Name = "btnSaturday";
			btnSaturday.Size = new Size(88, 46);
			btnSaturday.TabIndex = 5;
			btnSaturday.Text = "Saturday";
			btnSaturday.UseVisualStyleBackColor = true;
			// 
			// btnFriday
			// 
			btnFriday.Location = new Point(477, 3);
			btnFriday.Margin = new Padding(4, 3, 4, 3);
			btnFriday.Name = "btnFriday";
			btnFriday.Size = new Size(88, 46);
			btnFriday.TabIndex = 4;
			btnFriday.Text = "Friday";
			btnFriday.UseVisualStyleBackColor = true;
			// 
			// btnThusday
			// 
			btnThusday.Location = new Point(383, 3);
			btnThusday.Margin = new Padding(4, 3, 4, 3);
			btnThusday.Name = "btnThusday";
			btnThusday.Size = new Size(88, 46);
			btnThusday.TabIndex = 3;
			btnThusday.Text = "Thursday";
			btnThusday.UseVisualStyleBackColor = true;
			btnThusday.Click += btnThusday_Click;
			// 
			// btnWednesday
			// 
			btnWednesday.Location = new Point(288, 3);
			btnWednesday.Margin = new Padding(4, 3, 4, 3);
			btnWednesday.Name = "btnWednesday";
			btnWednesday.Size = new Size(88, 46);
			btnWednesday.TabIndex = 2;
			btnWednesday.Text = "Wednesday";
			btnWednesday.UseVisualStyleBackColor = true;
			// 
			// btnTuesday
			// 
			btnTuesday.Location = new Point(194, 3);
			btnTuesday.Margin = new Padding(4, 3, 4, 3);
			btnTuesday.Name = "btnTuesday";
			btnTuesday.Size = new Size(88, 46);
			btnTuesday.TabIndex = 1;
			btnTuesday.Text = "Tuesday";
			btnTuesday.UseVisualStyleBackColor = true;
			btnTuesday.Click += btnTuesday_Click;
			// 
			// btnMonday
			// 
			btnMonday.Location = new Point(99, 3);
			btnMonday.Margin = new Padding(4, 3, 4, 3);
			btnMonday.Name = "btnMonday";
			btnMonday.Size = new Size(88, 46);
			btnMonday.TabIndex = 0;
			btnMonday.Text = "Monday";
			btnMonday.UseVisualStyleBackColor = true;
			// 
			// Plan
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(892, 552);
			Controls.Add(panel1);
			Margin = new Padding(4, 3, 4, 3);
			Name = "Plan";
			Text = "Calender";
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nmNotify).EndInit();
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.NumericUpDown nmNotify;
		private System.Windows.Forms.CheckBox ckbNotify;
		private System.Windows.Forms.Button btnToDay;
		private System.Windows.Forms.DateTimePicker dtpkDate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
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
	}
}