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
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            register.ShowDialog();
            this.Hide();
        }

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Form login = new Login();
            this.Hide();
            login.ShowDialog();
		}
	}

}
