using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodhabits.Models
{
	public class Response
	{
		public int ResponseId { get; set; }
		public bool Answer { get; set; }
		public int GoalId { get; set; }
		public Goal Goal { get; set; }
	}
}