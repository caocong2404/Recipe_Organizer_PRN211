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
			txtFeedback = new TextBox();
			btnClose = new Button();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Montserrat ExtraBold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(348, 26);
			label1.Name = "label1";
			label1.Size = new Size(136, 32);
			label1.TabIndex = 0;
			label1.Text = "Feedback";
			// 
			// txtFeedback
			// 
			txtFeedback.Location = new Point(12, 71);
			txtFeedback.Multiline = true;
			txtFeedback.Name = "txtFeedback";
			txtFeedback.ScrollBars = ScrollBars.Vertical;
			txtFeedback.Size = new Size(780, 315);
			txtFeedback.TabIndex = 1;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(690, 392);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(75, 34);
			btnClose.TabIndex = 6;
			btnClose.Text = "Close";
			btnClose.Click += btnClose_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnClose);
			groupBox1.Location = new Point(3, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(807, 436);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			// 
			// ShowAllFeedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(822, 450);
			Controls.Add(txtFeedback);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Name = "ShowAllFeedback";
			Text = "ShowAllFeedback";
			Load += ShowAllFeedback_Load;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtFeedback;
		private Button btnClose;
		private Label label2;
		private Label label3;
		private TextBox txtRecipeName;
		private GroupBox groupBox1;
		private TextBox txtRatingAvg;
	}
}