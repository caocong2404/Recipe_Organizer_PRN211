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
	public partial class ChangePasswordAdmin : Form
	{
		UserRepository _userRepository;
		public ChangePasswordAdmin()
		{
			_userRepository = new UserRepository();
			InitializeComponent();
		}

		private void btnUserProfile_Click(object sender, EventArgs e)
		{

		}

		private void btnChangePassword_Click_1(object sender, EventArgs e)
		{
			string oldPassword = txtOldPassword.Text;
			string newPassword = txtNewPassword.Text;
			string confirmPassword = txtConfirm.Text;

			if (oldPassword.Length == 0)
			{
				MessageBox.Show("Old password not empty", "Warning");
				return;
			}
			if (newPassword.Length == 0)
			{
				MessageBox.Show("New password not empty", "Warning");
				return;
			}
			if (confirmPassword.Length == 0)
			{
				MessageBox.Show("Confirm password not empty", "Warning");
				return;
			}
			if (confirmPassword.Equals(newPassword))
			{
				var user = _userRepository.getUser(AppContext.CurrentUser.Username);
				user.Password = newPassword;
				_userRepository.Update(user);
				MessageBox.Show("Change password successfully", "Success");
				Form login = new Login();
				this.Close();
				login.Show();
			}
			else
			{
				MessageBox.Show("New password and confirm password not match", "Warning");
				return;
			}
		}

		private void btnUserProfile_Click_1(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void ChangePasswordAdmin_Load(object sender, EventArgs e)
		{

		}


	}
}
