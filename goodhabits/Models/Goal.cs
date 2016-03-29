using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodhabits.Models
{
	public class Goal
	{
		public int GoalId { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Question { get; set; }
		public decimal Weight { get; set; }
		public int SessionId { get; set; }

	}
}