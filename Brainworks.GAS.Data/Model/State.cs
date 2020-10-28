using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System;

namespace BrainWorks.GAS.Data
{
	public class State
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShortCode { get; set; }
		public List<User> Users { get; set; }
	}
}
