namespace Recipe_Organizer_PRN211.Authentication
{
	partial class Register
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
			txtPassword = new TextBox();
			txtUsername = new TextBox();
			btnRegister = new Button();
			label1 = new Label();
			label3 = new Label();
			txtConfirmPassword = new TextBox();
			label4 = new Label();
			label5 = new Label();
			btnBack = new Button();
			notifyRegister = new NotifyIcon(components);
			SuspendLayout();
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(222, 285);
			txtPassword.Margin = new Padding(3, 4, 3, 4);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(279, 27);
			txtPassword.TabIndex = 2;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(222, 200);
			txtUsername.Margin = new Padding(3, 4, 3, 4);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(279, 27);
			txtUsername.TabIndex = 1;
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnRegister.Location = new Point(222, 439);
			btnRegister.Margin = new Padding(3, 4, 3, 4);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(280, 48);
			btnRegister.TabIndex = 4;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(222, 168);
			label1.Name = "label1";
			label1.Size = new Size(114, 26);
			label1.TabIndex = 4;
			label1.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(222, 253);
			label3.Name = "label3";
			label3.Size = new Size(109, 26);
			label3.TabIndex = 6;
			label3.Text = "Password";
			// 
			// txtConfirmPassword
			// 
			txtConfirmPassword.Location = new Point(222, 368);
			txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.PasswordChar = '*';
			txtConfirmPassword.Size = new Size(279, 27);
			txtConfirmPassword.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(222, 336);
			label4.Name = "label4";
			label4.Size = new Size(195, 26);
			label4.TabIndex = 8;
			label4.Text = "Confirm password";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(192, 0, 0);
			label5.Location = new Point(286, 76);
			label5.Name = "label5";
			label5.Size = new Size(174, 47);
			label5.TabIndex = 9;
			label5.Text = "Register";
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BackgroundImage = Properties.Resources.left_arrow;
			btnBack.BackgroundImageLayout = ImageLayout.Zoom;
			btnBack.Location = new Point(26, 28);
			btnBack.Margin = new Padding(3, 4, 3, 4);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(104, 51);
			btnBack.TabIndex = 19;
			btnBack.TextAlign = ContentAlignment.MiddleLeft;
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// notifyRegister
			// 
			notifyRegister.Text = "notifyIcon1";
			notifyRegister.Visible = true;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.login_background;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(715, 600);
			Controls.Add(btnBack);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtConfirmPassword);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(btnRegister);
			Controls.Add(txtUsername);
			Controls.Add(txtPassword);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 4, 3, 4);
			Name = "Register";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Register";
			Load += Register_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtPassword;
		private TextBox txtUsername;
		private Button btnRegister;
		private Label label1;
		private Label label3;
		private TextBox txtConfirmPassword;
		private Label label4;
		private Label label5;
		private Button btnBack;
		private NotifyIcon notifyRegister;
	}
}