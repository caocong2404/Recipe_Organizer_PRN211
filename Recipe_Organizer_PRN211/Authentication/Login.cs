using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Organizer_PRN211.Authentication
{
	public partial class Login : Form
	{
		UserRepository _userRepository;
		public Login()
		{
			_userRepository = new UserRepository();
			InitializeComponent();
		}
		

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUsername.Text;
			string password = txtPassword.Text;
			if (checkLogin(userName, password))
			{
				var user = _userRepository.getUser(userName, password);
				if (user != null)
				{
                    Form adminPage = new AdminPage();
                    adminPage.ShowDialog();
                    this.Hide();
     //               if (user.Role.Equals("admin"))
					//{
     //                   Form adminPage = new AdminPage();
     //                   adminPage.ShowDialog();
     //                   this.Hide();
     //               } else if (user.Role.Equals("cook")) {
     //                   Form userProfile = new UserProfile();
     //                   userProfile.ShowDialog();
     //                   this.Hide();
     //               }
				}
			}
		}
		private bool checkLogin(string username, string password) {
			bool result = false;
			var user = _userRepository.getUser(username, password);
			if (user != null)
			{
				result = true;
			}
			return result;
		}
	}
}
