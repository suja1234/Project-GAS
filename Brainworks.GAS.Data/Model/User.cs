using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.GAS.Data
{
	public class User
	{
        //user
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
