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
			label2 = new Label();
			label3 = new Label();
			txtRecipeName = new TextBox();
			groupBox1 = new GroupBox();
			txtRatingAvg = new TextBox();
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
			txtFeedback.Location = new Point(12, 102);
			txtFeedback.Multiline = true;
			txtFeedback.Name = "txtFeedback";
			txtFeedback.ScrollBars = ScrollBars.Vertical;
			txtFeedback.Size = new Size(780, 284);
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(21, 64);
			label2.Name = "label2";
			label2.Size = new Size(129, 24);
			label2.TabIndex = 3;
			label2.Text = "Recipe Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(523, 61);
			label3.Name = "label3";
			label3.Size = new Size(146, 24);
			label3.TabIndex = 4;
			label3.Text = "Rating Average:";
			// 
			// txtRecipeName
			// 
			txtRecipeName.Location = new Point(156, 61);
			txtRecipeName.Name = "txtRecipeName";
			txtRecipeName.Size = new Size(345, 27);
			txtRecipeName.TabIndex = 5;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtRatingAvg);
			groupBox1.Controls.Add(btnClose);
			groupBox1.Location = new Point(3, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(807, 436);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			// 
			// txtRatingAvg
			// 
			txtRatingAvg.Location = new Point(667, 46);
			txtRatingAvg.Name = "txtRatingAvg";
			txtRatingAvg.Size = new Size(98, 27);
			txtRatingAvg.TabIndex = 7;
			// 
			// ShowAllFeedback
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(822, 450);
			Controls.Add(txtRecipeName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtFeedback);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Name = "ShowAllFeedback";
			Text = "ShowAllFeedback";
			Load += ShowAllFeedback_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
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