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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            btnLogin = new Button();
            btnRegister = new Button();
            colorDialog1 = new ColorDialog();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(42, 123);
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
            btnRegister.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(42, 201);
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
            label5.Cursor = Cursors.SizeNWSE;
            label5.Font = new Font("Montserrat ExtraBold", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(19, 12);
            label5.Name = "label5";
            label5.Size = new Size(472, 68);
            label5.TabIndex = 12;
            label5.Text = "Recipe Organizer";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_food;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(683, 431);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Cursor = Cursors.PanSE;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            Text = "Homepage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private ColorDialog colorDialog1;
        private Label label5;
    }
}