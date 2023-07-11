using Recipe_Organizer_PRN211.Authentication;
using Recipe_Organizer_PRN211.Plan;
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
		private RecipeDetail _recipeDetailForm;
		private UserRepository _userRepository;
		public SearchRecipe()
		{

			InitializeComponent();
			_recipeRepository = new RecipeRepository();
			_userRepository = new UserRepository();
			RefreshRecipeList();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchValue = txtSearch.Text;
			if (searchValue.Length > 0)
			{
				var recipeList = _recipeRepository.searchRecipeWithStatus(searchValue, "public");

				// Update DataGridView
				//dgvRecipeList.DataSource = new BindingSource()
				//{
				//	DataSource = recipeList.Select(r => new
				//	{
				//		r.RecipeId,
				//		r.Title,
				//		r.Date
				//	})
				//};

				// Update ListBox
				lstRecipes.Items.Clear();
				foreach (var recipe in recipeList)
				{
					lstRecipes.Items.Add($"{recipe.RecipeId} - {recipe.Title} - {recipe.Date}");
				}
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshRecipeList();
			txtSearch.Text = "";
		}

		private void RefreshRecipeList()
		{
			var recipeList = _recipeRepository.GetRecipeWithStatus("public");
			//dgvRecipeList.DataSource = new BindingSource()
			//{
			//	DataSource = recipeList.Select(r => new
			//	{
			//		r.RecipeId,
			//		r.Title,
			//		r.Date
			//	})
			//};

			lstRecipes.Items.Clear();
			foreach (var recipe in recipeList)
			{
				lstRecipes.Items.Add($"{recipe.RecipeId} - {recipe.Title} - Update on {recipe.Date}");
			}

		}

		//private void dgvRecipeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	if (e.RowIndex >= 0 && e.RowIndex < dgvRecipeList.Rows.Count)
		//	{
		//		var recipeID = dgvRecipeList[0, e.RowIndex].Value;
		//		if (recipeID != null && int.TryParse(recipeID.ToString(), out int recipeId))
		//		{
		//			AppContext.RecipeId = recipeId;
		//			this.Hide();
		//			RecipeDetail recipeDetailForm = new RecipeDetail();
		//			recipeDetailForm.ShowDialog();
		//		}
		//		else
		//		{
		//			MessageBox.Show("Sorry, Recipe is not found", "Message", MessageBoxButtons.OK);
		//		}
		//	}
		//}

		private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedRecipe = lstRecipes.SelectedItem?.ToString();
			if (selectedRecipe != null)
			{
				int recipeId;
				if (int.TryParse(selectedRecipe.Split('-')[0].Trim(), out recipeId))
				{
					AppContext.RecipeId = recipeId;
					this.Hide();
					RecipeDetail recipeDetailForm = new RecipeDetail(1);
					recipeDetailForm.ShowDialog();
				}
				else
				{
					MessageBox.Show("Sorry, Recipe is not found", "Message", MessageBoxButtons.OK);
				}
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form login = new Homepage();
			this.Hide();
			login.Show();
		}

		private void btnUserProfile_Click(object sender, EventArgs e)
		{
			Form userProfile = new UserProfile();
			this.Hide();
			userProfile.Show();
		}

		private void SearchRecipe_Load(object sender, EventArgs e)
		{
			string userName = Authentication.AppContext.CurrentUser.Username;
			User user = _userRepository.getUser(userName);
			if (user.FirstName != null)
				txtWelcome.Text = "Hello " + user.FirstName;
			else
				txtWelcome.Text = "Hello " + user.Username;
		}

		private void btnAddRecipe_Click(object sender, EventArgs e)
		{
			Form addReipce = new AddRecipe();
			this.Hide();
			addReipce.ShowDialog();
		}

		private void btnMealPlanning_Click(object sender, EventArgs e)
		{
			Form mealPlanning = new PlanView();
			this.Hide();
			mealPlanning.ShowDialog();
		}
	}
}
