using Recipe_Organizer_PRN211.Recipe;

namespace Recipe_Organizer_PRN211.Plan
{
    partial class Search
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
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lbTitle = new Label();
            lstRecipes = new ListBox();
            txtWelcome = new Label();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(509, 139);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(416, 139);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(61, 139);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(348, 27);
            txtSearch.TabIndex = 18;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lbTitle.Location = new Point(441, 73);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(257, 36);
            lbTitle.TabIndex = 22;
            lbTitle.Text = "ALL OF RECIPES";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstRecipes
            // 
            lstRecipes.FormattingEnabled = true;
            lstRecipes.ItemHeight = 20;
            lstRecipes.Location = new Point(61, 192);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(999, 544);
            lstRecipes.TabIndex = 23;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;
            // 
            // txtWelcome
            // 
            txtWelcome.AutoSize = true;
            txtWelcome.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtWelcome.Location = new Point(27, 23);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(88, 36);
            txtWelcome.TabIndex = 57;
            txtWelcome.Text = "Hello";
            txtWelcome.Click += txtWelcome_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1113, 811);
            Controls.Add(txtWelcome);
            Controls.Add(lstRecipes);
            Controls.Add(lbTitle);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeList";
            Load += SearchRecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lbTitle;
        private ListBox lstRecipes;
        private Label txtWelcome;
    }
}