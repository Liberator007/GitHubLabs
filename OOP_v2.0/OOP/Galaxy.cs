using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Galaxy: SpaceObjects
    {
        public int Weight
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public Galaxy(string name, Location location, int age, int diameter, double shine, string type, int weight)
            : base(name, location, age, diameter, shine)
        {
            Type = type;
            Weight = weight;           
        }
    }
}
