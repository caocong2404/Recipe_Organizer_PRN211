using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe_Organizer_PRN211.Authentication;

namespace Recipe_Organizer_PRN211
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += timer1_Tick;
            timer.Start();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            this.Hide();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("HH:mm:ss dd/MM");
        }
    }

}
