using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class AppUser
    {
        public int AppUserId { get; set; }

        public int AddressTypeshipping = 1;

        public int AddressTypebilling = 2;
        public int Role { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
