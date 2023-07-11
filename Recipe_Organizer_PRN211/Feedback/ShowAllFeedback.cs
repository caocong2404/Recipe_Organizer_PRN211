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

					if (feedbackFields.Length >= 7)
					{
						txtFeedback.AppendText($"Username: {feedbackFields[1]}\r\nRecipeName: {feedbackFields[2]}\r\nTitle: {feedbackFields[3]}\r\nDescription: {feedbackFields[4]}\r\nRating: {feedbackFields[5]}\r\nDate: {feedbackFields[6]}\r\n\r\n");
					}
				}
			}
			else
			{
				MessageBox.Show("Feedback file not found.", "Error");
			}
		}
	}
}
