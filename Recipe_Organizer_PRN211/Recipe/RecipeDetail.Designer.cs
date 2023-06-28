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
			label5 = new Label();
			lbTitle = new Label();
			label1 = new Label();
			label2 = new Label();
			lbDate = new Label();
			pictureBox1 = new PictureBox();
			tlpIngredients = new TableLayoutPanel();
			tlpDirection = new TableLayoutPanel();
			btnBack = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(192, 0, 0);
			label5.Location = new Point(27, 25);
			label5.Name = "label5";
			label5.Size = new Size(145, 47);
			label5.TabIndex = 13;
			label5.Text = "Recipe";
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Montserrat Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
			lbTitle.Location = new Point(425, 65);
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
			label1.Location = new Point(58, 182);
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
			lbDate.Location = new Point(58, 122);
			lbDate.Name = "lbDate";
			lbDate.Size = new Size(50, 20);
			lbDate.TabIndex = 21;
			lbDate.Text = "label4";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(618, 163);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(493, 279);
			pictureBox1.TabIndex = 22;
			pictureBox1.TabStop = false;
			// 
			// tlpIngredients
			// 
			tlpIngredients.ColumnCount = 2;
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.Location = new Point(82, 238);
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
			btnBack.Location = new Point(58, 738);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(194, 59);
			btnBack.TabIndex = 25;
			btnBack.Text = "Back to recipes list";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// RecipeDetail
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1202, 819);
			Controls.Add(btnBack);
			Controls.Add(tlpDirection);
			Controls.Add(tlpIngredients);
			Controls.Add(pictureBox1);
			Controls.Add(lbDate);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lbTitle);
			Controls.Add(label5);
			Margin = new Padding(3, 4, 3, 4);
			Name = "RecipeDetail";
			Text = "RecipeDetail";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label5;
		private Label lbTitle;
		private Label label1;
		private Label label2;
		private Label lbDate;
		private PictureBox pictureBox1;
		private TableLayoutPanel tlpIngredients;
		private TableLayoutPanel tlpDirection;
		private Button btnBack;
	}
}