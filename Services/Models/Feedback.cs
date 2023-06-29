using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Services.Models
{
    public partial class Feedback
    {

		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public DateTime Date { get; set; }
		public int? Rating { get; set; }
		public bool Status { get; set; }

		public virtual User User { get; set; } = null!;


	}
}
