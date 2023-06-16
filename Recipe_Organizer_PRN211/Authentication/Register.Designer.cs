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
			txtEmail = new TextBox();
			txtPassword = new TextBox();
			txtUsername = new TextBox();
			btnRegister = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtConfirmPassword = new TextBox();
			label4 = new Label();
			label5 = new Label();
			SuspendLayout();
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(195, 172);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(245, 23);
			txtEmail.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(195, 234);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(245, 23);
			txtPassword.TabIndex = 1;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(195, 111);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(245, 23);
			txtUsername.TabIndex = 2;
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnRegister.Location = new Point(195, 341);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(245, 36);
			btnRegister.TabIndex = 3;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(195, 87);
			label1.Name = "label1";
			label1.Size = new Size(89, 21);
			label1.TabIndex = 4;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(195, 148);
			label2.Name = "label2";
			label2.Size = new Size(135, 21);
			label2.TabIndex = 5;
			label2.Text = "Email (optional)";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(195, 210);
			label3.Name = "label3";
			label3.Size = new Size(86, 21);
			label3.TabIndex = 6;
			label3.Text = "Password";
			// 
			// txtConfirmPassword
			// 
			txtConfirmPassword.Location = new Point(195, 296);
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.Size = new Size(245, 23);
			txtConfirmPassword.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(195, 272);
			label4.Name = "label4";
			label4.Size = new Size(154, 21);
			label4.TabIndex = 8;
			label4.Text = "Confirm password";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(192, 0, 0);
			label5.Location = new Point(249, 22);
			label5.Name = "label5";
			label5.Size = new Size(140, 37);
			label5.TabIndex = 9;
			label5.Text = "Register";
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(626, 450);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(txtConfirmPassword);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnRegister);
			Controls.Add(txtUsername);
			Controls.Add(txtPassword);
			Controls.Add(txtEmail);
			Name = "Register";
			Text = "Register";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtEmail;
		private TextBox txtPassword;
		private TextBox txtUsername;
		private Button btnRegister;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtConfirmPassword;
		private Label label4;
		private Label label5;
	}
}