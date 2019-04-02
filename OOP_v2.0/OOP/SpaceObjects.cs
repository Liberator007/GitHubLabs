using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class SpaceObjects
    {
        public string Name
        {
            get; set;
        }
        public Location Location
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public int Diameter
        {
            get; set;
        }
        public double Shine
        {
            get; set;
        }
        public SpaceObjects(string name, Location location, int age, int diameter, double shine)
        {
            Name = name;
            Location = location;
            Age = age;
            Diameter = diameter;
            Shine = shine;
        }
    }
}
