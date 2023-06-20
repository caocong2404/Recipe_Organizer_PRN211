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
	public partial class Register : Form
	{
		UserRepository _userRepository;
		public Register()
		{


			_userRepository = new UserRepository();
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			string userName = txtUsername.Text;
			string email = txtEmail.Text;
			string password = txtPassword.Text;
			if (_userRepository.checkUserExisted(userName))
			{
                // login fail
                MessageBox.Show("Username is exist", "Warning", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtUsername.Text = "";
				return;
            } 
			User user = new User();
			user.Username = userName;
			user.Email = email;
			user.Password = password;
			user.Role = "Cook";
			_userRepository.Add(user);
			MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


			// Hide the current form
			this.Hide();

			// Show the login form
			Form login = new Login();
			login.ShowDialog();

			// Close the current form
			this.Close();

		}
	}
}
