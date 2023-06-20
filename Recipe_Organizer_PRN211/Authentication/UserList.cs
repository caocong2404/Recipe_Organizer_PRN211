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
        public UserList()
        {
            _userRepository = new UserRepository();
            InitializeComponent();
            var userList = _userRepository.GetAll();
            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string firstName = txtFirstname.Text;
            string lastname = txtLastname.Text;
            DateTime birhday = dateBirthday.Value;
            string email = txtEmail.Text;



            //if (name.Length <= 0 || brand.Length <= 0)
            //{
            //    MessageBox.Show("Textbox can not empty", "Thong bao", MessageBoxButtons.OK);
            //    return;
            //}
            //if (int.TryParse(name, out int checkName))
            //{
            //    MessageBox.Show("Account name can not be number", "Thong bao", MessageBoxButtons.OK);
            //    return;
            //}

            //if (int.TryParse(brand, out int checkBrand))
            //{
            //    MessageBox.Show("Brand name can not be number", "Thong bao", MessageBoxButtons.OK);
            //    return;
            //}
            //var bankAccount = new BankAccount();
            //bankAccount.AccountName = name;
            //bankAccount.BranchName = brand;
            //bankAccount.OpenDate = DateTime.Now;
            ////get account type name
            //AccountType accountType = cBTypeName.SelectedItem as AccountType;

            //bankAccount.TypeId = accountType.TypeId;

            //_bankAccountRepository.Add(bankAccount);
            //var bankAccountList = _bankAccountRepository.GetAll();

            //dgvListStudent.DataSource = new BindingSource()
            //{
            //    DataSource = bankAccountList
            //};
        }
    }
}
