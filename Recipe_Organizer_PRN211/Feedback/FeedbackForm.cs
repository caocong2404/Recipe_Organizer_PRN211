using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Services.Service;
using Services.Services;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Services.Models;


namespace Recipe_Organizer_PRN211.Feedback
{
	public partial class FeedbackForm : Form
	{
		private int rating = 0;
		private PictureBox[] stars;

		FeedbackRepository _feedbackRepository;
		RecipeRepository _recipeRepository;
		public FeedbackForm()
		{
			_feedbackRepository = new FeedbackRepository();
			_recipeRepository = new RecipeRepository();
			InitializeComponent();
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			ShowAllFeedback showAllFeedback = new ShowAllFeedback();
			showAllFeedback.Show();

			//string feedback = "Title: " + txtTitle.Text + Environment.NewLine;
			//feedback += "Description: " + txtDescription.Text;
			//feedback += "Rating: " + rating + " star(s)" + Environment.NewLine;
			//feedback += "Date: " + DateTime.Now;
			//MessageBox.Show(feedback); 

		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTitle.Text) || rating == 0)
			{
				MessageBox.Show("Title or rating is invalid!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int recipeId = Recipe_Organizer_PRN211.Recipe.AppContext.RecipeId;
			Services.Models.Recipe recipe = _recipeRepository.GetRecipe(recipeId);
			var recipeName = recipe.Title;
			var userId = Recipe_Organizer_PRN211.Authentication.AppContext.CurrentUser.UserId;
			var userName = Recipe_Organizer_PRN211.Authentication.AppContext.CurrentUser.Username;
			var feedback = new Services.Models.Feedback();
			feedback.UserId = userId;
			feedback.Title = txtTitle.Text;
			feedback.Description = txtDescription.Text;
			feedback.Date = DateTime.Now;
			feedback.Rating = rating;
			string feedbackText = $"{feedback.UserId}\t{userName}\t{recipeName}\t{feedback.Title}\t{feedback.Description}\t{feedback.Rating}\t{feedback.Date}";
			string feedbackFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "feedback.txt");
			File.AppendAllText(feedbackFilePath, feedbackText + Environment.NewLine);
			//_feedbackRepository.Add();

			string dataDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Data");
			if (!Directory.Exists(dataDirectory))
			{
				Directory.CreateDirectory(dataDirectory);
			}

			// Optional: Display a message to the user that the feedback was submitted successfully
			MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Optional: Clear the form for the next feedback submission
			//txtTitle.Text = "";
			//star1.Image = Properties.Resources.star_empty;
			//star2.Image = Properties.Resources.star_empty;
			//star3.Image = Properties.Resources.star_empty;
			//star4.Image = Properties.Resources.star_empty;
			//star5.Image = Properties.Resources.star_empty;
			//txtDescription.Text = "";


		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (txtDescription.Text.Length > 0)
			{
				txtDescription.Text = txtDescription.Text.Remove(txtDescription.Text.Length - 1, 1);
			}
			else
			{
				MessageBox.Show("Please enter your comment before deleting the feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDescription.Clear();
		}

		private void star_Click(object sender, EventArgs e)
		{
			star1.Image = Properties.Resources.star_empty;
			star2.Image = Properties.Resources.star_empty;
			star3.Image = Properties.Resources.star_empty;
			star4.Image = Properties.Resources.star_empty;
			star5.Image = Properties.Resources.star_empty;

			// Set the clicked stars control and all preceding ones to the star-filled image
			PictureBox selectedstar = (PictureBox)sender;
			selectedstar.Image = Properties.Resources.star_filled;
			if (selectedstar == star1) rating = 1;
			else if (selectedstar == star2) rating = 2;
			else if (selectedstar == star3) rating = 3;
			else if (selectedstar == star4) rating = 4;
			else if (selectedstar == star5) rating = 5;
			else rating = 0;

		}

		private void txtDescription_Click(object sender, EventArgs e)
		{
			txtDescription.Clear();
		}
	}
}
