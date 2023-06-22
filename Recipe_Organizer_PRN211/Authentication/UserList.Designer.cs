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
            components = new System.ComponentModel.Container();
            label5 = new Label();
            dgvListUser = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            userBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
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
            cbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
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
            dgvListUser.AutoGenerateColumns = false;
            dgvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListUser.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn });
            dgvListUser.DataSource = userBindingSource;
            dgvListUser.Location = new Point(12, 86);
            dgvListUser.Name = "dgvListUser";
            dgvListUser.RowTemplate.Height = 25;
            dgvListUser.Size = new Size(864, 145);
            dgvListUser.TabIndex = 13;
            dgvListUser.CellDoubleClick += dgvListUser_CellDoubleClick;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Services.Models.User);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(305, 23);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(323, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Montserrat Medium", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(404, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
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
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(662, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dateBirthday
            // 
            dateBirthday.Location = new Point(99, 376);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(229, 23);
            dateBirthday.TabIndex = 35;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(500, 337);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(229, 23);
            cbRole.TabIndex = 36;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(cbRole);
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
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvListUser);
            Controls.Add(label5);
            Name = "UserList";
            Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)dgvListUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvListUser;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
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
        private ComboBox cbRole;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private BindingSource userBindingSource;
    }
}