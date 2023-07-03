using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
	public class FeedbackRepository: RepositoryBase<Feedback>
	{
		Recipe_Organizer_PRN211Context _context;
		DbSet<Feedback> _dbSet;

		public FeedbackRepository()
		{
			_context = new Recipe_Organizer_PRN211Context();
			_dbSet = _context.Set<Feedback>();
		}
		public List<Feedback> GetAll()
		{ 
			return _dbSet.ToList();
		}

		public Feedback ShowAllFeedback(int feedbackId)
		{
			var feedback = _dbSet.Where(entity => entity.FeedbackId == feedbackId).FirstOrDefault();
			return feedback;
		}

	}
}
