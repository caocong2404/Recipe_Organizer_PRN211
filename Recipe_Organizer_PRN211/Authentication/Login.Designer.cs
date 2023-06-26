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
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);

            label5.Location = new Point(251, 87);

            label5.Name = "label5";
            label5.Size = new Size(123, 47);
            label5.TabIndex = 10;
            label5.Text = "Login";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

            label3.Location = new Point(188, 229);

            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

            label1.Location = new Point(188, 150);

            label1.Name = "label1";
            label1.Size = new Size(114, 26);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

            btnLogin.Location = new Point(188, 298);

            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 48);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 

            txtUsername.Location = new Point(188, 174);

            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(279, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 

            txtPassword.Location = new Point(188, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(245, 23);

            txtPassword.TabIndex = 12;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.left_arrow;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(12, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 38);
            btnBack.TabIndex = 18;
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Login
            // 

            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(626, 450);
            Controls.Add(btnBack);

            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");

            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label1;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnBack;
    }
}