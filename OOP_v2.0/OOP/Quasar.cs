using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Quasar: BlackHole
    {
        public int LengthJet
        {
            get; set;
        }
        public Quasar(string name, Location location, int age, int diameter, double shine, int weight, int lengthJet) 
            : base(name, location, age, diameter, shine, weight)
        {
            LengthJet = lengthJet;
        }
    }
}
