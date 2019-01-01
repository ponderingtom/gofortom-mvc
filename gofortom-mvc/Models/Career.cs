using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gofortom_mvc.Models
{
	public class Career
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int StartYear { get; set; }
		public int? EndYear { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }

		public List<Skill> Skills { get; set; } = new List<Skill>();
	}

	public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Level { get; set; }
	}
}