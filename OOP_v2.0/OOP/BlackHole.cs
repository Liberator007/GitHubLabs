using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class BlackHole: SpaceObjects
    {
        public int Weight
        {
            get; set;
        }
        public BlackHole(string name, Location location, int age, int diameter, double shine, int weight)
            : base(name, location, age, diameter, shine)
        {
            Weight = weight;
        }
    }
}
