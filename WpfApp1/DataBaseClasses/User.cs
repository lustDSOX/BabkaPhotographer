using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBaseClasses
{
    public class User
    {
        int Id { get; set; }
        string Login { get; set; }
        string Passowd{ get; set; }
        Role Role { get; set; }
        public User(string login, string passowd, Role role)
        {
            Login = login;
            Passowd = passowd;
            Role = role;
        }
        public User() { }
    }
}
