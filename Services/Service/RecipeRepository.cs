using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
	public class RecipeRepository : RepositoryBase<Recipe>
	{
		Recipe_Organizer_PRN211Context _context;
		DbSet<Recipe> _dbSet;

		public string GetTitle (int recipeId)
		{
			return GetRecipe(recipeId).Title;
		}
		public RecipeRepository()
		{
			_context = new Recipe_Organizer_PRN211Context();
			_dbSet = _context.Set<Recipe>();
		}

		public Recipe GetRecipe(int recipeId)
		{
			var recipe = _dbSet.Where(entity => entity.RecipeId == recipeId).FirstOrDefault();
			return recipe;
		}

		public List<Recipe> GetRecipeWithStatus(string status)
		{
			var listRecipe = _dbSet.Where(entity => entity.Status == status).ToList();
			return listRecipe;
		}

		public List<Recipe> searchRecipeWithStatus(string keyword, string status)
		{
			var records = _dbSet.Where(entity => entity.Title.Contains(keyword) && entity.Status.Equals(status)).ToList();
			return records;
		}

		public List<Recipe> getRecipe(string keyword)
        {
            var records = _dbSet.Where(entity => entity.Title.Contains(keyword)).ToList();
            return records;
        }

		public bool updateRecipeStatus(int recipeID, string status)
		{
			bool result = false;
			var recipe = GetAll().Where(p => p.RecipeId == recipeID).FirstOrDefault();
			if (recipe == null)
				return result;
			if (status.Equals("Approve"))
			{
				recipe.Status = "public";
				result = true;
			} 
			else if (status.Equals("Reject"))
			{
				recipe.Status = "reject";
				result = true;
			}
			Update(recipe);
			return result;
		}
    }
}
