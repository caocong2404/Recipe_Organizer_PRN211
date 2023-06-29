using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CategoryCRUD : Form
    {
        //UserRepository _userRepository;
        CategoryRepository _categoryRepository;
        RecipeHasCategoryRepository _recipeHasCategoryRepository;
        Category category;
        public CategoryCRUD()
        {
            // _userRepository = new UserRepository();
            _categoryRepository = new CategoryRepository();
            _recipeHasCategoryRepository = new RecipeHasCategoryRepository();

            InitializeComponent();
            var CategoryList = _categoryRepository.GetAll();
            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = CategoryList
            };


        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string categoryName = txtUsername.Text;
            string categoryDrciption = txtPassword.Text;



            if (validateInput(categoryName, categoryDrciption))
            {
                MessageBox.Show("Textbox can not empty", "Warning", MessageBoxButtons.OK);
                return;
            }

            var category = new Category();
            category.Title = txtUsername.Text;
            category.Description = txtPassword.Text;


            _categoryRepository.Add(category);


            var userList = _categoryRepository.GetAll();

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
            string categoryName = txtUsername.Text;
            string categoryDrciption = txtPassword.Text;

            if (validateInput(categoryName, categoryDrciption))
            {
                MessageBox.Show("Textbox can not empty", "Warning", MessageBoxButtons.OK);
                return;
            }

            var category = new Category();
            category.Title = txtUsername.Text;
            category.Description = txtPassword.Text;

            _categoryRepository.Update(category);

            var userList = _categoryRepository.GetAll();

            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = userList
            };
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show(
        //        "Do you want do delete user?",
        //        "Confirm", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.No)
        //    {
        //        return;
        //    }
        //    _userRepository.Delete(user);
        //    MessageBox.Show("Delete successfull");
        //    var userList = _userRepository.GetAll();

        //    dgvListUser.DataSource = new BindingSource()
        //    {
        //        DataSource = userList
        //    };

        //    txtUsername.Text = "";
        //    txtPassword.Text = "";

        //}


        private void dgvListUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chuột đang click ở dòng nào
            var userID = dgvListUser[0, e.RowIndex].Value;
            var category = _categoryRepository.GetAll().Where(entity => entity.CategoryId.Equals(userID)).FirstOrDefault();
            this.category = category;
            if (category == null)
                return;


            txtUsername.Text = category.Title.ToString();
            if (category.Title != null)
                txtUsername.Text = category.Title.ToString();
            if (category.Description != null)
                txtPassword.Text = category.Description.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue.Length > 0)
            {
                var userList = _categoryRepository.getUserByUserName(searchValue);

                dgvListUser.DataSource = new BindingSource()
                {
                    DataSource = userList
                };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var listUser = _categoryRepository.GetAll();
            dgvListUser.DataSource = new BindingSource()
            {
                DataSource = listUser
            };
        }

        private void dgvListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
