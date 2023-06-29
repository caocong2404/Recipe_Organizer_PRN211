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

                    // Clear any existing controls in the table layout panel
                    tlpIngredients.Controls.Clear();

                    // Set the column and row styles to autosize
                    tlpIngredients.ColumnStyles.Clear();
                    tlpIngredients.RowStyles.Clear();
                    tlpIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                    // Add a row for each ingredient
                    string[] ingredients = recipe.Ingredient.Split(new[] { "\\n" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        tlpIngredients.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                        // Create a Label control for the ingredient
                        Label ingredientLabel = new Label();
                        ingredientLabel.Text = ingredients[i];
                        ingredientLabel.AutoSize = true;

                        // Add the Label control to the table layout panel
                        tlpIngredients.Controls.Add(ingredientLabel, 0, i);
                    }

                    // Clear any existing controls in the table layout panel
                    tlpDirection.Controls.Clear();

                    // Set the column and row styles to autosize
                    tlpDirection.ColumnStyles.Clear();
                    tlpDirection.RowStyles.Clear();
                    tlpDirection.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tlpDirection.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                    // Add a row for each step in the description
                    string[] steps = recipe.Description.Split(new[] { "\\n" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < steps.Length; i++)
                    {
                        tlpDirection.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                        // Create a Label control for the step description
                        Label stepLabel = new Label();
                        stepLabel.Text = $"Step {i + 1}: {steps[i]}";
                        stepLabel.AutoSize = true;

                        // Add the Label control to the table layout panel
                        tlpDirection.Controls.Add(stepLabel, 0, i);
                    }

                    lbDate.Text = "Date: " + recipe.Date.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchRecipe recipeListForm = new SearchRecipe();
            recipeListForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form searhRecipe = new SearchRecipe();
            this.Hide();
            searhRecipe.ShowDialog();
        }
    }
}
