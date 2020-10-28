using System;
using System.Data.SqlTypes;
using System.Text;
namespace BrainWorks.GAS.Data
{
	public class ConnectionDetails
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ConnectionTypeId { get; set; }
		public int ConsumerNumber { get; set; }
		public varchar ConsumerName { get; set; }
		public varchar DeliveryAddress { get; set; }
		public dateTime ConnectionRequestDate { get; set; }
		public datetime ConnectionApprovedDate { get; set; }
		public money DepositAmount { get; set; }
		public int Regulator { get; set; }
		public varchar Status { get; set; }
	}
}
