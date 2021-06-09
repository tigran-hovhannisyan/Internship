
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class User
    {
        public string Name;
        public string Surname;
        public string Username;
        public string Password;

        public User() 
        {
            Name = "Guest";
            Surname = "Guest";
            Username = "";
            Password = "";
        }

        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
    }
}
