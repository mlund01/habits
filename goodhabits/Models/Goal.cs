using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodhabits.Models
{
	public class Goal
	{
		public int GoalId { get; set; }
		public string Description { get; set; }
		public string Question { get; set; }
		public decimal Weight { get; set; }
		public int SessionId { get; set; }
		public Session Session { get; set; }

	}
}