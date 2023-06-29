namespace Recipe_Organizer_PRN211.Manage
{
	partial class PendingRecipe
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
			components = new System.ComponentModel.Container();
			btnRefresh = new Button();
			btnSearch = new Button();
			txtSearch = new TextBox();
			dgvPendingRecipe = new DataGridView();
			label5 = new Label();
			recipeBindingSource = new BindingSource(components);
			recipeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			ingredientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			imgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dgvPendingRecipe).BeginInit();
			((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
			SuspendLayout();
			// 
			// btnRefresh
			// 
			btnRefresh.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
			btnRefresh.Location = new Point(418, 34);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(75, 23);
			btnRefresh.TabIndex = 41;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnSearch
			// 
			btnSearch.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
			btnSearch.Location = new Point(337, 34);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(75, 23);
			btnSearch.TabIndex = 40;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(26, 34);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(305, 23);
			txtSearch.TabIndex = 39;
			// 
			// dgvPendingRecipe
			// 
			dgvPendingRecipe.AutoGenerateColumns = false;
			dgvPendingRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPendingRecipe.Columns.AddRange(new DataGridViewColumn[] { recipeIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, ingredientDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, imgDataGridViewTextBoxColumn });
			dgvPendingRecipe.DataSource = recipeBindingSource;
			dgvPendingRecipe.Location = new Point(26, 74);
			dgvPendingRecipe.Name = "dgvPendingRecipe";
			dgvPendingRecipe.RowTemplate.Height = 25;
			dgvPendingRecipe.Size = new Size(794, 388);
			dgvPendingRecipe.TabIndex = 38;
			dgvPendingRecipe.CellContentClick += dgvPendingRecipe_CellContentClick;
			dgvPendingRecipe.CellDoubleClick += dgvPendingRecipe_CellDoubleClick;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(192, 0, 0);
			label5.Location = new Point(568, 19);
			label5.Name = "label5";
			label5.Size = new Size(241, 37);
			label5.TabIndex = 37;
			label5.Text = "Pending recipe";
			// 
			// recipeBindingSource
			// 
			recipeBindingSource.DataSource = typeof(Services.Models.Recipe);
			// 
			// recipeIdDataGridViewTextBoxColumn
			// 
			recipeIdDataGridViewTextBoxColumn.DataPropertyName = "RecipeId";
			recipeIdDataGridViewTextBoxColumn.HeaderText = "RecipeId";
			recipeIdDataGridViewTextBoxColumn.Name = "recipeIdDataGridViewTextBoxColumn";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			titleDataGridViewTextBoxColumn.HeaderText = "Title";
			titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// ingredientDataGridViewTextBoxColumn
			// 
			ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
			ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
			ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
			// 
			// dateDataGridViewTextBoxColumn
			// 
			dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dateDataGridViewTextBoxColumn.HeaderText = "Date";
			dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// statusDataGridViewTextBoxColumn
			// 
			statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			statusDataGridViewTextBoxColumn.HeaderText = "Status";
			statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			// 
			// imgDataGridViewTextBoxColumn
			// 
			imgDataGridViewTextBoxColumn.DataPropertyName = "Img";
			imgDataGridViewTextBoxColumn.HeaderText = "Img";
			imgDataGridViewTextBoxColumn.Name = "imgDataGridViewTextBoxColumn";
			// 
			// PendingRecipe
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(843, 474);
			Controls.Add(btnRefresh);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
			Controls.Add(dgvPendingRecipe);
			Controls.Add(label5);
			Name = "PendingRecipe";
			Text = "PendingRecipe";
			((System.ComponentModel.ISupportInitialize)dgvPendingRecipe).EndInit();
			((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbRole;
		private DateTimePicker dateBirthday;
		private Button btnDelete;
		private Button btnCreate;
		private Label label8;
		private Label label7;
		private TextBox txtPassword;
		private TextBox txtEmail;
		private TextBox txtLastname;
		private Label label6;
		private Label label4;
		private Button btnRefresh;
		private Button btnSearch;
		private TextBox txtSearch;
		private DataGridView dgvPendingRecipe;
		private Label label5;
		private DataGridViewTextBoxColumn recipeIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn imgDataGridViewTextBoxColumn;
		private BindingSource recipeBindingSource;
	}
}