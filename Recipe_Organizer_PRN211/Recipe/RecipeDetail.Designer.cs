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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(817, 19);
            label5.Name = "label5";
            label5.Size = new Size(210, 37);
            label5.TabIndex = 13;
            label5.Text = "Recipe detail";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Montserrat Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lbTitle.Location = new Point(411, 54);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(226, 33);
            lbTitle.TabIndex = 14;
            lbTitle.Text = "TITLE HEREEEEE";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 136);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 15;
            label1.Text = "Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 355);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 17;
            label2.Text = "Directions";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(51, 92);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(38, 15);
            lbDate.TabIndex = 21;
            lbDate.Text = "label4";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(511, 100);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(461, 266);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 28;
            pictureBox.TabStop = false;
            // 
            // tlpIngredients
            // 
            tlpIngredients.ColumnCount = 2;
            tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngredients.Location = new Point(72, 178);
            tlpIngredients.Margin = new Padding(3, 2, 3, 2);
            tlpIngredients.Name = "tlpIngredients";
            tlpIngredients.RowCount = 2;
            tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngredients.Size = new Size(387, 153);
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
            tlpDirection.Location = new Point(72, 390);
            tlpDirection.Margin = new Padding(3, 2, 3, 2);
            tlpDirection.Name = "tlpDirection";
            tlpDirection.RowCount = 2;
            tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDirection.Size = new Size(900, 119);
            tlpDirection.TabIndex = 24;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(255, 549);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 44);
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
            button1.Location = new Point(26, 19);
            button1.Name = "button1";
            button1.Size = new Size(76, 38);
            button1.TabIndex = 26;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddFeedback
            // 
            btnAddFeedback.Location = new Point(70, 549);
            btnAddFeedback.Margin = new Padding(3, 2, 3, 2);
            btnAddFeedback.Name = "btnAddFeedback";
            btnAddFeedback.Size = new Size(164, 44);
            btnAddFeedback.TabIndex = 27;
            btnAddFeedback.Text = "Add new Feedback";
            btnAddFeedback.UseVisualStyleBackColor = true;
            btnAddFeedback.Click += btnAddFeedback_Click;
            // 
            // RecipeDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 614);
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