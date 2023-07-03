namespace Recipe_Organizer_PRN211.Feedback
{
	partial class FeedbackForm
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
			label3 = new Label();
			label5 = new Label();
			label4 = new Label();
			txtTitle = new TextBox();
			txtDescription = new TextBox();
			btnClear = new Button();
			btnDelete = new Button();
			btnShowAll = new Button();
			btnSubmit = new Button();
			btnExit = new Button();
			pictureBox1 = new PictureBox();
			star1 = new PictureBox();
			star2 = new PictureBox();
			star3 = new PictureBox();
			star4 = new PictureBox();
			star5 = new PictureBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)star1).BeginInit();
			((System.ComponentModel.ISupportInitialize)star2).BeginInit();
			((System.ComponentModel.ISupportInitialize)star3).BeginInit();
			((System.ComponentModel.ISupportInitialize)star4).BeginInit();
			((System.ComponentModel.ISupportInitialize)star5).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(55, 32);
			label1.Name = "label1";
			label1.Size = new Size(55, 24);
			label1.TabIndex = 0;
			label1.Text = "Title: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(70, 147);
			label3.Name = "label3";
			label3.Size = new Size(0, 20);
			label3.TabIndex = 2;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(55, 268);
			label5.Name = "label5";
			label5.Size = new Size(294, 24);
			label5.TabIndex = 4;
			label5.Text = "What do you think of this recipe?";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(55, 73);
			label4.Name = "label4";
			label4.Size = new Size(205, 24);
			label4.TabIndex = 5;
			label4.Text = "How can we improve ?";
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(150, 29);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(255, 27);
			txtTitle.TabIndex = 6;
			// 
			// txtDescription
			// 
			txtDescription.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtDescription.ForeColor = Color.DimGray;
			txtDescription.Location = new Point(55, 115);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(694, 140);
			txtDescription.TabIndex = 9;
			txtDescription.Text = "Enter your Feedback...\r\n";
			// 
			// btnClear
			// 
			btnClear.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnClear.Location = new Point(671, 113);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(78, 29);
			btnClear.TabIndex = 10;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnDelete.Location = new Point(587, 113);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(78, 29);
			btnDelete.TabIndex = 11;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnShowAll
			// 
			btnShowAll.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnShowAll.Location = new Point(493, 397);
			btnShowAll.Name = "btnShowAll";
			btnShowAll.Size = new Size(88, 29);
			btnShowAll.TabIndex = 12;
			btnShowAll.Text = "Show All";
			btnShowAll.UseVisualStyleBackColor = true;
			btnShowAll.Click += btnShowAll_Click;
			// 
			// btnSubmit
			// 
			btnSubmit.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnSubmit.Location = new Point(587, 397);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(78, 29);
			btnSubmit.TabIndex = 13;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = true;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btnExit.Location = new Point(671, 397);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(78, 29);
			btnExit.TabIndex = 14;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.star_0;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(11, 17);
			pictureBox1.TabIndex = 15;
			pictureBox1.TabStop = false;
			// 
			// star1
			// 
			star1.Image = Properties.Resources.star_empty;
			star1.Location = new Point(93, 309);
			star1.Name = "star1";
			star1.Size = new Size(50, 51);
			star1.SizeMode = PictureBoxSizeMode.CenterImage;
			star1.TabIndex = 16;
			star1.TabStop = false;
			star1.Click += star_Click;
			// 
			// star2
			// 
			star2.Image = Properties.Resources.star_empty;
			star2.Location = new Point(151, 309);
			star2.Name = "star2";
			star2.Size = new Size(50, 51);
			star2.SizeMode = PictureBoxSizeMode.CenterImage;
			star2.TabIndex = 17;
			star2.TabStop = false;
			star2.Click += star_Click;
			// 
			// star3
			// 
			star3.Image = Properties.Resources.star_empty;
			star3.Location = new Point(209, 309);
			star3.Name = "star3";
			star3.Size = new Size(50, 51);
			star3.SizeMode = PictureBoxSizeMode.CenterImage;
			star3.TabIndex = 18;
			star3.TabStop = false;
			star3.Click += star_Click;
			// 
			// star4
			// 
			star4.Image = Properties.Resources.star_empty;
			star4.Location = new Point(267, 309);
			star4.Name = "star4";
			star4.Size = new Size(50, 51);
			star4.SizeMode = PictureBoxSizeMode.CenterImage;
			star4.TabIndex = 19;
			star4.TabStop = false;
			star4.Click += star_Click;
			// 
			// star5
			// 
			star5.Image = Properties.Resources.star_empty;
			star5.Location = new Point(325, 309);
			star5.Name = "star5";
			star5.Size = new Size(50, 51);
			star5.SizeMode = PictureBoxSizeMode.CenterImage;
			star5.TabIndex = 20;
			star5.TabStop = false;
			star5.Click += star_Click;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(55, 291);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(357, 77);
			groupBox1.TabIndex = 21;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Location = new Point(27, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(746, 437);
			groupBox2.TabIndex = 22;
			groupBox2.TabStop = false;
			// 
			// FeedbackForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 451);
			Controls.Add(star5);
			Controls.Add(star4);
			Controls.Add(star3);
			Controls.Add(star2);
			Controls.Add(star1);
			Controls.Add(pictureBox1);
			Controls.Add(btnExit);
			Controls.Add(btnSubmit);
			Controls.Add(btnShowAll);
			Controls.Add(btnDelete);
			Controls.Add(btnClear);
			Controls.Add(txtDescription);
			Controls.Add(txtTitle);
			Controls.Add(label4);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "FeedbackForm";
			Text = "FeedbackForm";
			Click += star_Click;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)star1).EndInit();
			((System.ComponentModel.ISupportInitialize)star2).EndInit();
			((System.ComponentModel.ISupportInitialize)star3).EndInit();
			((System.ComponentModel.ISupportInitialize)star4).EndInit();
			((System.ComponentModel.ISupportInitialize)star5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label3;
		private Label label5;
		private Label label4;
		private TextBox txtTitle;
		private TextBox txtDescription;
		private Button btnClear;
		private Button btnDelete;
		private Button btnShowAll;
		private Button btnSubmit;
		private Button btnExit;
		private PictureBox pictureBox1;
		private PictureBox star1;
		private PictureBox star2;
		private PictureBox star3;
		private PictureBox star4;
		private PictureBox star5;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
	}
}