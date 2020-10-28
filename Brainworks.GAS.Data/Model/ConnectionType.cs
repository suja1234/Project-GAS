using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BrainWorks.GAS.Data
{
	public class ConnectionType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int RefillCharge { get; set; }
		public int NewConnectionCharge { get; set; }

	}
}
