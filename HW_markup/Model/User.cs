using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_markup.Model
{
    internal class User
    {
        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
        public string Name { get; private set; }
        public string Login { get; private set; }
        string Password { get; set; }

        public bool isAutorisation(string password) => password == Password;


    }
}
