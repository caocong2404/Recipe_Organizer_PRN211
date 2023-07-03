using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Services.Service;
using Services.Services;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Models;
using System.CodeDom;
using System.Windows.Forms.DataVisualization.Charting;

namespace Recipe_Organizer_PRN211.Feedback
{
	public partial class ShowAllFeedback : Form
	{
		RecipeRepository recipeRepository; 
		public ShowAllFeedback()
		{
			recipeRepository = new RecipeRepository();
			InitializeComponent();
			int recipeId = Recipe_Organizer_PRN211.Recipe.AppContext.RecipeId;
			Services.Models.Recipe recipe = recipeRepository.GetRecipe(recipeId);
			// Display the recipe name in the recipeNameTextBox
			txtRecipeName.Text = recipe.Title;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ShowAllFeedback_Load(object sender, EventArgs e)
		{
			string feedbackFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "feedback.txt");
			string[] feedbackLines = File.ReadAllLines(feedbackFilePath);

			if (File.Exists(feedbackFilePath))
			{
				foreach (string feedbackLine in feedbackLines)
				{
					string[] feedbackFields = feedbackLine.Split('\t');

					if (feedbackFields.Length >= 6)
					{
						txtFeedback.AppendText($"Username: {feedbackFields[1]}\r\nTitle: {feedbackFields[2]}\r\nDescription: {feedbackFields[3]}\r\nRating: {feedbackFields[4]}\r\nDate: {feedbackFields[5]}\r\n\r\n");
					}
				}
			}
			else
			{
				MessageBox.Show("Feedback file not found.", "Error");
			}

			// Calculate the average rating of the feedback
			double ratingSum = 0;
			foreach (string feedbackLine in feedbackLines)
			{
				string[] feedbackFields = feedbackLine.Split('\t');
				if (feedbackFields.Length >= 6)
				{
					ratingSum += double.Parse(feedbackFields[4]);
				}
			}
			double ratingAvg = ratingSum / feedbackLines.Length;

			// Display the average rating in the rating textbox
			txtRatingAvg.Text = ratingAvg.ToString("0.00");
		}
	}
}
