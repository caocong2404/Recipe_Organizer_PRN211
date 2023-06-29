using Recipe_Organizer_PRN211.Recipe;
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

			txtUsername.Focus();

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
					AppContext.CurrentUser = user;
					//Form adminPage = new AdminPage();
					//this.Hide();
					//adminPage.ShowDialog();
					if (user.Role == 1)
					{
						Form adminPage = new AdminPage();
						this.Hide();
						adminPage.ShowDialog();
					}
					else if (user.Role == 2)
					{
						//Form userProfile = new UserProfile();
						Form recipeList = new SearchRecipe();
						this.Hide();
						recipeList.ShowDialog();
					}
				}
			}
			MessageBox.Show("User not valid", "Warning", MessageBoxButtons.OK);
			return;
		}
		private bool checkLogin(string username, string password)
		{
			bool result = false;
			var user = _userRepository.getUser(username, password);
			if (user != null)
			{
				result = true;
			}
			return result;
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			//push update
			Form loginForm = new Homepage();
			this.Hide();
			loginForm.ShowDialog();

		}


		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
