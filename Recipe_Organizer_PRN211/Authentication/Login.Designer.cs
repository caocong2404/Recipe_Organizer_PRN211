namespace Recipe_Organizer_PRN211.Authentication
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			label3 = new Label();
			label1 = new Label();
			btnLogin = new Button();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnBack = new Button();
			label2 = new Label();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(215, 305);
			label3.Name = "label3";
			label3.Size = new Size(109, 26);
			label3.TabIndex = 17;
			label3.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(215, 200);
			label1.Name = "label1";
			label1.Size = new Size(114, 26);
			label1.TabIndex = 15;
			label1.Text = "Username";
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.Location = new Point(215, 397);
			btnLogin.Margin = new Padding(3, 4, 3, 4);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(320, 64);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(215, 232);
			txtUsername.Margin = new Padding(3, 4, 3, 4);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(318, 27);
			txtUsername.TabIndex = 1;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(215, 337);
			txtPassword.Margin = new Padding(3, 4, 3, 4);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(318, 27);
			txtPassword.TabIndex = 2;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BackgroundImage = Properties.Resources.left_arrow;
			btnBack.BackgroundImageLayout = ImageLayout.Zoom;
			btnBack.Location = new Point(14, 28);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(104, 51);
			btnBack.TabIndex = 18;
			btnBack.TextAlign = ContentAlignment.MiddleLeft;
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(192, 0, 0);
			label2.Location = new Point(323, 111);
			label2.Name = "label2";
			label2.Size = new Size(123, 47);
			label2.TabIndex = 19;
			label2.Text = "Login";
			// 
			// Login
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.login_background;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(715, 600);
			Controls.Add(label2);
			Controls.Add(btnBack);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(btnLogin);
			Controls.Add(txtUsername);
			Controls.Add(txtPassword);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label3;
		private Label label1;
		private Button btnLogin;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnBack;
		private Label label2;
	}
}