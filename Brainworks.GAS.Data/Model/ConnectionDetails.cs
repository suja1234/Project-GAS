using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BrainWorks.GAS.Data
{
	public class ConnectionDetails
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ConnectionTypeId { get; set; }
		public int ConsumerNumber { get; set; }
		public string ConsumerName { get; set; }
		public string DeliveryAddress { get; set; }
		public DateTime ConnectionRequestDate { get; set; }
		public DateTime ConnectionApprovedDate { get; set; }
		public int DepositAmount { get; set; }
		public int Regulator { get; set; }
		public string Status { get; set; }
	}
}
