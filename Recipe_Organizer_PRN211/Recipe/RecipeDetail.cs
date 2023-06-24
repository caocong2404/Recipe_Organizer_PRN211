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
			// Get the recipe from the database
			int recipeId = 1; 
			Services.Models.Recipe recipe = _recipeRepository.GetRecipe(recipeId);

			// Populate the controls with recipe details
			//lbTitle.Text = "Spaghetti Sauce with Ground Beef";
			//lbIngredient.Text = "This recipe has been handed down from my mother. It is a family favorite and will not be replaced! (Definite husband pleaser!) Serve over any variety of hot cooked pasta.";
			//lbDescription.Text = "This recipe has been handed down from my mother. It is a family favorite and will not be replaced! (Definite husband pleaser!) Serve over any variety of hot cooked pasta.";
			//lbDate.Text = "Date: ";

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
