namespace Recipe_Organizer_PRN211.Authentication
{
    partial class UserList
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
            dgvListUser = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            empty = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dateBirthday = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListUser).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(644, 31);
            label5.Name = "label5";
            label5.Size = new Size(144, 37);
            label5.TabIndex = 12;
            label5.Text = "User List";
            // 
            // dgvListUser
            // 
            dgvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListUser.Location = new Point(12, 86);
            dgvListUser.Name = "dgvListUser";
            dgvListUser.RowTemplate.Height = 25;
            dgvListUser.Size = new Size(776, 145);
            dgvListUser.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(323, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(404, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // empty
            // 
            empty.AutoSize = true;
            empty.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            empty.Location = new Point(12, 262);
            empty.Name = "empty";
            empty.Size = new Size(81, 18);
            empty.TabIndex = 18;
            empty.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 295);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 19;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(399, 300);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 20;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 337);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 21;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 375);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 22;
            label6.Text = "Birthday";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(99, 262);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(229, 23);
            txtUsername.TabIndex = 23;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(99, 299);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(229, 23);
            txtFirstname.TabIndex = 24;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(500, 295);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(229, 23);
            txtLastname.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 336);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(500, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(399, 263);
            label7.Name = "label7";
            label7.Size = new Size(73, 18);
            label7.TabIndex = 29;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(399, 342);
            label8.Name = "label8";
            label8.Size = new Size(38, 18);
            label8.TabIndex = 30;
            label8.Text = "Role";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(500, 375);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 29);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(581, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(662, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dateBirthday
            // 
            dateBirthday.Location = new Point(99, 376);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(229, 23);
            dateBirthday.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(500, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 36;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(dateBirthday);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(empty);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dgvListUser);
            Controls.Add(label5);
            Name = "UserList";
            Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)dgvListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvListUser;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label empty;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label7;
        private Label label8;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker dateBirthday;
        private ComboBox comboBox1;
    }
}