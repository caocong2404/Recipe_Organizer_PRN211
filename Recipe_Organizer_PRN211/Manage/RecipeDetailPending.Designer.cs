namespace Recipe_Organizer_PRN211.Manage
{
	partial class RecipeDetailPending
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetailPending));
			btnBack = new Button();
			tlpDirection = new TableLayoutPanel();
			tlpIngredients = new TableLayoutPanel();
			label2 = new Label();
			label1 = new Label();
			lbTitle = new Label();
			btnReject = new Button();
			btnApprove = new Button();
			recipePicture = new PictureBox();
			lbDate = new Label();
			((System.ComponentModel.ISupportInitialize)recipePicture).BeginInit();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BackgroundImage = Properties.Resources.left_arrow;
			btnBack.BackgroundImageLayout = ImageLayout.Zoom;
			btnBack.Location = new Point(10, 5);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(76, 38);
			btnBack.TabIndex = 35;
			btnBack.TextAlign = ContentAlignment.MiddleLeft;
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click_1;
			// 
			// tlpDirection
			// 
			tlpDirection.AutoScroll = true;
			tlpDirection.AutoSize = true;
			tlpDirection.ColumnCount = 2;
			tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpDirection.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			tlpDirection.Location = new Point(76, 407);
			tlpDirection.Margin = new Padding(3, 2, 3, 2);
			tlpDirection.Name = "tlpDirection";
			tlpDirection.RowCount = 2;
			tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpDirection.Size = new Size(900, 119);
			tlpDirection.TabIndex = 34;
			// 
			// tlpIngredients
			// 
			tlpIngredients.ColumnCount = 2;
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpIngredients.Location = new Point(76, 195);
			tlpIngredients.Margin = new Padding(3, 2, 3, 2);
			tlpIngredients.Name = "tlpIngredients";
			tlpIngredients.RowCount = 2;
			tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpIngredients.Size = new Size(387, 153);
			tlpIngredients.TabIndex = 33;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(55, 372);
			label2.Name = "label2";
			label2.Size = new Size(80, 20);
			label2.TabIndex = 30;
			label2.Text = "Directions";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(55, 153);
			label1.Name = "label1";
			label1.Size = new Size(89, 20);
			label1.TabIndex = 29;
			label1.Text = "Ingredients";
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Montserrat Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
			lbTitle.Location = new Point(144, 58);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(226, 33);
			lbTitle.TabIndex = 28;
			lbTitle.Text = "TITLE HEREEEEE";
			lbTitle.TextAlign = ContentAlignment.TopCenter;
			// 
			// btnReject
			// 
			btnReject.BackColor = Color.Red;
			btnReject.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
			btnReject.ForeColor = Color.White;
			btnReject.Location = new Point(848, 5);
			btnReject.Name = "btnReject";
			btnReject.Size = new Size(141, 50);
			btnReject.TabIndex = 63;
			btnReject.Text = "Reject";
			btnReject.UseVisualStyleBackColor = false;
			btnReject.Click += btnReject_Click;
			// 
			// btnApprove
			// 
			btnApprove.BackColor = Color.Lime;
			btnApprove.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
			btnApprove.Location = new Point(701, 5);
			btnApprove.Name = "btnApprove";
			btnApprove.Size = new Size(141, 50);
			btnApprove.TabIndex = 62;
			btnApprove.Text = "Approve";
			btnApprove.UseVisualStyleBackColor = false;
			btnApprove.Click += btnApprove_Click;
			// 
			// recipePicture
			// 
			recipePicture.Location = new Point(545, 139);
			recipePicture.Margin = new Padding(3, 2, 3, 2);
			recipePicture.Name = "recipePicture";
			recipePicture.Size = new Size(431, 209);
			recipePicture.TabIndex = 32;
			recipePicture.TabStop = false;
			// 
			// lbDate
			// 
			lbDate.AutoSize = true;
			lbDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lbDate.Location = new Point(55, 109);
			lbDate.Name = "lbDate";
			lbDate.Size = new Size(63, 25);
			lbDate.TabIndex = 31;
			lbDate.Text = "label4";
			// 
			// RecipeDetailPending
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1041, 555);
			Controls.Add(btnReject);
			Controls.Add(btnApprove);
			Controls.Add(btnBack);
			Controls.Add(tlpDirection);
			Controls.Add(tlpIngredients);
			Controls.Add(recipePicture);
			Controls.Add(lbDate);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lbTitle);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "RecipeDetailPending";
			Text = "RecipeDetailPending";
			((System.ComponentModel.ISupportInitialize)recipePicture).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBack;
		private TableLayoutPanel tlpDirection;
		private TableLayoutPanel tlpIngredients;
		private Label label2;
		private Label label1;
		private Label lbTitle;
		private Button btnReject;
		private Button btnApprove;
		private PictureBox recipePicture;
		private Label lbDate;
	}
}