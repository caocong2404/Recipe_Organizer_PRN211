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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            btnLogin = new Button();
            btnRegister = new Button();
            label5 = new Label();
            panel1 = new Panel();
            txtDate = new Label();
            txtTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(347, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Yellow;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(347, 239);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 48);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Sign in";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Montserrat ExtraBold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(28, 79);
            label5.Name = "label5";
            label5.Size = new Size(472, 68);
            label5.TabIndex = 12;
            label5.Text = "Recipe Organizer";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(171, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 431);
            panel1.TabIndex = 13;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Montserrat ExtraBold", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            txtDate.ForeColor = Color.MediumBlue;
            txtDate.Location = new Point(237, 23);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(88, 40);
            txtDate.TabIndex = 14;
            txtDate.Text = "time";
            // 
            // txtTimer
            // 
            txtTimer.Tick += timer1_Tick;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_food;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(683, 431);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Label label5;
        private Panel panel1;
        private System.Windows.Forms.Timer txtTimer;
        private Label txtDate;
    }
}