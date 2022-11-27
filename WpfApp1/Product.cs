using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Product
    {
        public string Name { get; set; }
        public string Count { get; set; }
        public string Price { get; set; }

        public Product(string name, string count, string price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
