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

namespace Recipe_Organizer_PRN211.Recipe
{
    public partial class SearchRecipe : Form
    {
        private RecipeRepository _recipeRepository;
        public SearchRecipe()
        {
            InitializeComponent();
            _recipeRepository = new RecipeRepository();
            var recipeList = _recipeRepository.GetAll();
            dgvRecipeList.DataSource = new BindingSource()
            {
                DataSource = recipeList
            };

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (searchValue.Length > 0)
            {
                var recipeList = _recipeRepository.getRecipe(searchValue);

                dgvRecipeList.DataSource = new BindingSource()
                {
                    DataSource = recipeList
                };
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var recipeList = _recipeRepository.GetAll();
            dgvRecipeList.DataSource = new BindingSource()
            {
                DataSource = recipeList
            };
        }

        private void dgvRecipeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var recipeID = dgvRecipeList[0, e.RowIndex].Value;
            var recipe = _recipeRepository.GetAll().Where(entity => entity.UserId.Equals(recipeID)).FirstOrDefault();
            if (recipe != null)
            {
                return;
            }
        }
    }
}
