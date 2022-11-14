using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBaseClasses
{
    public class Contrpartner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Contrpartner(string name)
        {
            Name = name;
        }
        public Contrpartner() {}
    }
}
