namespace Recipe_Organizer_PRN211.Feedback
{
	partial class ShowAllFeedback
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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Montserrat ExtraBold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(179, 27);
			label1.Name = "label1";
			label1.Size = new Size(136, 32);
			label1.TabIndex = 0;
			label1.Text = "Feedback";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 62);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Vertical;
			textBox1.Size = new Size(461, 324);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(379, 409);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Close";
			button1.UseVisualStyleBackColor = true;
			// 
			// ShowAllFeedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(496, 450);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ShowAllFeedback";
			Text = "ShowAllFeedback";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
	}
}