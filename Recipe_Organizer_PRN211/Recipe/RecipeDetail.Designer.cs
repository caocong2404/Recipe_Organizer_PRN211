namespace Recipe_Organizer_PRN211.Recipe
{
	partial class RecipeDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetail));
			label5 = new Label();
			lbTitle = new Label();
			label1 = new Label();
			label2 = new Label();
			lbDate = new Label();

			pictureBox = new PictureBox();

			tlpIngredients = new TableLayoutPanel();
			tlpDirection = new TableLayoutPanel();
			btnBack = new Button();
			button1 = new Button();

			btnAddFeedback = new Button();

			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(192, 0, 0);
			label5.Location = new Point(934, 25);
			label5.Name = "label5";
			label5.Size = new Size(261, 47);
			label5.TabIndex = 13;
			label5.Text = "Recipe detail";
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Montserrat Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
			lbTitle.Location = new Point(470, 72);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(283, 41);
			lbTitle.TabIndex = 14;
			lbTitle.Text = "TITLE HEREEEEE";
			lbTitle.TextAlign = ContentAlignment.TopCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(58, 181);
			label1.Name = "label1";
			label1.Size = new Size(114, 25);
			label1.TabIndex = 15;
			label1.Text = "Ingredients";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(58, 473);
			label2.Name = "label2";
			label2.Size = new Size(102, 25);
			label2.TabIndex = 17;
			label2.Text = "Directions";
			// 
			// lbDate
			// 
			lbDate.AutoSize = true;
			lbDate.Location = new Point(58, 123);
			lbDate.Name = "lbDate";
			lbDate.Size = new Size(50, 20);
			lbDate.TabIndex = 21;
			lbDate.Text = "label4";
			// 



			// 
			// tlpIngredients
			// 
			tlpIngredients.ColumnCount = 2;
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.Location = new Point(82, 237);
			tlpIngredients.Name = "tlpIngredients";
			tlpIngredients.RowCount = 2;
			tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpIngredients.Size = new Size(442, 204);
			tlpIngredients.TabIndex = 23;
			// 
			// tlpDirection
			// 
			tlpDirection.AutoScroll = true;
			tlpDirection.AutoSize = true;
			tlpDirection.ColumnCount = 2;
			tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpDirection.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			tlpDirection.Location = new Point(82, 520);
			tlpDirection.Name = "tlpDirection";
			tlpDirection.RowCount = 2;
			tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpDirection.Size = new Size(1029, 159);
			tlpDirection.TabIndex = 24;
			// 
			// btnBack
			// 

			btnBack.Location = new Point(291, 732);

			btnBack.Name = "btnBack";
			btnBack.Size = new Size(194, 59);
			btnBack.TabIndex = 25;
			btnBack.Text = "Back to recipes list";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Transparent;
			button1.BackgroundImage = Properties.Resources.left_arrow;
			button1.BackgroundImageLayout = ImageLayout.Zoom;
			button1.Location = new Point(30, 25);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(87, 51);
			button1.TabIndex = 26;
			button1.TextAlign = ContentAlignment.MiddleLeft;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 

			// btnAddFeedback
			// 
			btnAddFeedback.Location = new Point(80, 732);
			btnAddFeedback.Name = "btnAddFeedback";
			btnAddFeedback.Size = new Size(187, 59);
			btnAddFeedback.TabIndex = 27;
			btnAddFeedback.Text = "Add new Feedback";
			btnAddFeedback.UseVisualStyleBackColor = true;
			btnAddFeedback.Click += btnAddFeedback_Click;
			// 

			// RecipeDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1202, 819);

			Controls.Add(btnAddFeedback);

			Controls.Add(button1);
			Controls.Add(btnBack);
			Controls.Add(tlpDirection);
			Controls.Add(tlpIngredients);

			Controls.Add(pictureBox);

			Controls.Add(lbDate);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lbTitle);
			Controls.Add(label5);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "RecipeDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RecipeDetail";

			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();

			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private Label lbTitle;
		private Label label1;
		private Label label2;
		private Label lbDate;

		private PictureBox pictureBox;

		private TableLayoutPanel tlpIngredients;
		private TableLayoutPanel tlpDirection;
		private Button btnBack;
		private Button button1;

		private Button btnAddFeedback;

	}
}