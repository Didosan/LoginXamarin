using System;
using System.Collections.Generic;
using System.Text;

namespace Login01.Models
{
    class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Users(object p) { }
        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if (this.Username.Equals("") && this.Password.Equals(""))
            {
                return true;
            }
            else
                return false;
        }
    }
}
