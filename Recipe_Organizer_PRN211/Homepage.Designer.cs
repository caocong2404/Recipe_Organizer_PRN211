namespace Recipe_Organizer_PRN211
{
	partial class Homepage
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
			btnLogin = new Button();
			btnRegister = new Button();
			SuspendLayout();
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.Location = new Point(463, 12);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(133, 40);
			btnLogin.TabIndex = 0;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnRegister.Location = new Point(622, 12);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(133, 40);
			btnRegister.TabIndex = 1;
			btnRegister.Text = "Sign in";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// Homepage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnRegister);
			Controls.Add(btnLogin);
			Name = "Homepage";
			Text = "Homepage";
			ResumeLayout(false);
		}

		#endregion

		private Button btnLogin;
		private Button btnRegister;
	}
}