using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Nebula: SpaceObjects
    {
        public string Composition
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public Nebula(string name, Location location, int age, int diameter, double shine, string type, string composition)
            : base(name, location, age, diameter, shine)
        {
            Type = type;
            Composition = composition;            
        }
    }
}
