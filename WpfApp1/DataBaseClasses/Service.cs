using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBaseClasses
{
    public class Service
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        public Service(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Service() { }
    }
}
