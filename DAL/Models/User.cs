using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class User
    {

        public long User__ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Instagram { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string JoinDate { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class UserApp : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

}
