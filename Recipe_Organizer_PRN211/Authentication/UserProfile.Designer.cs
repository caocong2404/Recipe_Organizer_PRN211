namespace Recipe_Organizer_PRN211.Authentication
{
    partial class UserProfile
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
            label5 = new Label();
            txtWelcome = new Label();
            dateBirthday = new DateTimePicker();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            empty = new Label();
            btnChangePassword = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(190, 37);
            label5.TabIndex = 10;
            label5.Text = "User Profile";
            // 
            // txtWelcome
            // 
            txtWelcome.AutoSize = true;
            txtWelcome.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            txtWelcome.Location = new Point(21, 70);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(79, 33);
            txtWelcome.TabIndex = 16;
            txtWelcome.Text = "Hello";
            // 
            // dateBirthday
            // 
            dateBirthday.Location = new Point(129, 251);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(229, 23);
            dateBirthday.TabIndex = 52;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(423, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(325, 45);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 45;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(524, 132);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(229, 23);
            txtLastname.TabIndex = 44;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(129, 174);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(229, 23);
            txtFirstname.TabIndex = 43;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 137);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(229, 23);
            txtUsername.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 250);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 41;
            label6.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 212);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 40;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(423, 137);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 39;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 179);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 38;
            label2.Text = "First name";
            // 
            // empty
            // 
            empty.AutoSize = true;
            empty.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            empty.Location = new Point(42, 137);
            empty.Name = "empty";
            empty.Size = new Size(81, 18);
            empty.TabIndex = 37;
            empty.Text = "User name";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.Location = new Point(423, 236);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(325, 45);
            btnChangePassword.TabIndex = 53;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(639, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 37);
            btnLogout.TabIndex = 54;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 373);
            Controls.Add(btnLogout);
            Controls.Add(btnChangePassword);
            Controls.Add(dateBirthday);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(empty);
            Controls.Add(txtWelcome);
            Controls.Add(label5);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label txtWelcome;
        private DateTimePicker dateBirthday;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private TextBox txtUsername;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label empty;
        private Button btnChangePassword;
        private Button btnLogout;
    }
}