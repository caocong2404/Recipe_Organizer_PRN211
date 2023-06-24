namespace Recipe_Organizer_PRN211.Recipe
{
	partial class RecipeList
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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(414, 46);
			label1.Name = "label1";
			label1.Size = new Size(248, 39);
			label1.TabIndex = 0;
			label1.Text = "ALL OF RECIPES";
			// 
			// RecipeList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1113, 621);
			Controls.Add(label1);
			Name = "RecipeList";
			Text = "RecipeList";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
	}
}