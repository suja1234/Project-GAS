using System;

namespace BrainWorks.GAS.Data
{
	public class BookingDetails
	{  
		public int Id { get; set;} 
		public int UserId {get; set;} 
		public int ConnectionId {get; set;} 
		public DateTime BookedDate {get; set;} 
		public DateTime DeliveredDate {get; set;} 
		public string Status {get; set;} 
		public int Money {get;set;}

	}
}
