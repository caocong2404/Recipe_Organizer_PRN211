using Services.Models;
using Services.Service;
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
    public partial class UserList : Form
    {
        UserRepository _userRepository;
        RoleRepository _roleRepository;
        User user;
        public UserList()
        {
            _userRepository = new UserRepository();
            _roleRepository = new RoleRepository();

            InitializeComponent();
            var userList = _userRepository.GetAll();
            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };

            var listRoles = _roleRepository.GetAll();
            cbRole.DataSource = listRoles;
            cbRole.DisplayMember = "RoleName";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string firstName = txtFirstname.Text;
            string lastname = txtLastname.Text;
            DateTime birhday = dateBirthday.Value;
            string email = txtEmail.Text;
            Role roles = cbRole.SelectedItem as Role;
            int role = roles.RoleId;


            if (validateInput(userName, password))
            {
                MessageBox.Show("Textbox can not empty", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (_userRepository.checkUserExisted(userName))
            {
                MessageBox.Show("Username is existed", "Warning", MessageBoxButtons.OK);
                return;
            }
            var user = new User();
            user.Username = userName.Trim();
            user.Password = password.Trim();
            user.FirstName = firstName.Trim();
            user.LastName = lastname.Trim();
            user.Email = email.Trim();
            user.Birthday = birhday;
            user.Role = role;

            _userRepository.Add(user);

            var userList = _userRepository.GetAll();

            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };
        }

        public bool validateInput(string userName, string password)
        {
            bool result = false;
            if (userName == null || password == null) { return result; }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text;
            string lastname = txtLastname.Text;
            DateTime birhday = dateBirthday.Value;
            string email = txtEmail.Text;
            Role roles = cbRole.SelectedItem as Role;
            int role = roles.RoleId;

            user.FirstName = firstName.Trim();
            user.LastName = lastname.Trim();
            user.Email = email.Trim();
            user.Birthday = birhday;
            user.Role = role;

            _userRepository.Update(user);

            var userList = _userRepository.GetAll();

            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want do delete user?",
                "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            _userRepository.Delete(user);
            MessageBox.Show("Delete successfull");
            var userList = _userRepository.GetAll();

            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };

            txtUsername.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPassword.Text = "";
            dateBirthday.Text = "";
            txtEmail.Text = "";
        }


        private void dgvListUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chuột đang click ở dòng nào
            var userID = dgvListUser[0, e.RowIndex].Value;
            var user = _userRepository.GetAll().Where(entity => entity.UserId.Equals(userID)).FirstOrDefault();
            this.user = user;
            if (user == null)
                return;

            var roleID = user.Role;
            //get role object
            var role = _roleRepository.GetAll().Where(entity => entity.RoleId.Equals(roleID)).FirstOrDefault();

            cbRole.Text = role.RoleName;
            txtUsername.Text = user.Username.ToString();
            if (user.FirstName != null)
                txtFirstname.Text = user.FirstName.ToString();
            if (user.LastName != null)
                txtLastname.Text = user.LastName.ToString();
            if (user.Email != null)
                txtEmail.Text = user.Email.ToString();
            txtPassword.Text = user.Password.ToString();
            if (user.Birthday != null)
                dateBirthday.Text = user.Birthday.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue.Length > 0)
            {
                var userList = _userRepository.getUserByUserName(searchValue);

                dgvListUser.DataSource = new BindingSource()
                {
                    DataSource = userList
                };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var listUser = _userRepository.GetAll();
            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = listUser
            };
        }
    }
}
