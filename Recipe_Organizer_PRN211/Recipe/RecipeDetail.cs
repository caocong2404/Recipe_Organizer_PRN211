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
    public partial class RecipeDetail : Form
    {
        private RecipeRepository _recipeRepository;

        public RecipeDetail()
        {
            InitializeComponent();
            _recipeRepository = new RecipeRepository();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (AppContext.RecipeId > 0)
            {
                // Get the recipe from the database
                int recipeId = AppContext.RecipeId;
                Services.Models.Recipe recipe = _recipeRepository.GetRecipe(recipeId);

                if (recipe != null)
                {
                    lbTitle.Text = recipe.Title;
                    lbIngredient.Text = recipe.Ingredient;
                    lbDescription.Text = recipe.Description;
                    lbDate.Text = "Date: " + recipe.Date.ToString();
                }
            }
        }
    }
}
