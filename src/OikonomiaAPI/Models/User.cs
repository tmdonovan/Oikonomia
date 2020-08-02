using System;
using System.Collections.Generic;

namespace OikonomiaAPI.Models
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime UpdateDt { get; set; }
    }
}
