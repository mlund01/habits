using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodhabits.Models
{
	public class UserResponse
	{
		public int UserResponseId { get; set; }
		[Required]
		public bool Answer { get; set; }
		[Required]
		public DateTime Date { get; set; }
		public string Note { get; set; }
		public int GoalId { get; set; }
	}
}