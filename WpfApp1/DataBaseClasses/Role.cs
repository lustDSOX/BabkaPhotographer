using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBaseClasses
{
    public class Role
    {
        int Id { get; set; }
        string Name { get; set; }
        public Role(string name)
        {
            Name = name;
        }
        public Role() { }
    }
}
