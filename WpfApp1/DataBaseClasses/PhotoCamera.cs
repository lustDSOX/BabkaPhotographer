using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBaseClasses
{
    public class PhotoCamera
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prise{ get; set; }

        public PhotoCamera(string name, double prise)
        {
            Name = name;
            Prise = prise;
        }

        public PhotoCamera() { }
    }
}
