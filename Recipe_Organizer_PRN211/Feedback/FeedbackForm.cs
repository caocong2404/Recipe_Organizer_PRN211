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
		FeedbackRepository _feedbackRepository;
		public FeedbackForm()
		{
			_feedbackRepository = new FeedbackRepository();
			InitializeComponent();
		}

		private void FeedbackType_Click(object sender, EventArgs e)
		{
			if (rbComment.Checked)
			{
				// Handle comment feedback type
				txtDescription.Enabled = true;
				btnDelete.Enabled = true;
				txtTitle.Enabled = false;
				txtDescription.Focus();
			}
			else if (rbReport.Checked)
			{
				// Handle report feedback type
				txtDescription.Enabled = false;
				btnDelete.Enabled = false;
				txtTitle.Enabled = true;
				txtTitle.Focus();
			}
		}

		private void FeedbackLevel_Click(object sender, EventArgs e)
		{
			if (rbVSatisfied.Checked)
			{
				// Handle satisfied feedback level
				MessageBox.Show("Thank you for your positive feedback!", "Feedback Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (rbSatisfied.Checked)
			{
				// Handle satisfied feedback level
				MessageBox.Show("Thank you for your positive feedback!", "Feedback Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (rbNeutral.Checked)
			{
				// Handle normal feedback level
				MessageBox.Show("Thank you for your feedback.", "Feedback Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (rbUnsatisfied.Checked)
			{
				// Handle unsatisfied feedback level
				MessageBox.Show("We're sorry to hear that. Please let us know how we can improve.", "Feedback Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (rbVUnsatisfied.Checked)
			{
				// Handle unsatisfied feedback level
				MessageBox.Show("We're sorry to hear that. Please let us know how we can improve.", "Feedback Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			btnShowAll.DialogResult = DialogResult.OK;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			var feedback = new Services.Models.Feedback();
			feedback.FeedbackId = 1; 
			feedback.Title = txtTitle.Text;
			feedback.Description = txtDescription.Text;
			feedback.Date = DateTime.Now;
			feedback.FeedbackType = rbComment.Checked ? "Comment" : "Report";
			feedback.FeedbackLevel = rbVSatisfied.Checked ? "Very satisfied" : rbSatisfied.Checked ? "Satisfied" : rbNeutral.Checked ? "Normal" : rbUnsatisfied.Checked ? "Unsatisfied" : "Very Unsatisfied";
			_feedbackRepository.Add(feedback);

			// Optional: Display a message to the user that the feedback was submitted successfully
			MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Optional: Clear the form for the next feedback submission
			txtTitle.Text = "";
			txtDescription.Text = "";
			rbComment.Checked = false;
			rbReport.Checked = false;
			rbVSatisfied.Checked = false;
			rbSatisfied.Checked = false;
			rbNeutral.Checked = false;
			rbUnsatisfied.Checked = false;
			rbVUnsatisfied.Checked = false;
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
	}
}
