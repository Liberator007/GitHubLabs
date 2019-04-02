using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class StarCluster: SpaceObjects
    {

        public string Type
        {
            get; set;
        }
        public StarCluster(string name, Location location, int age, int diameter, double shine, string type)
            : base(name, location, age, diameter, shine)
        {
            Type = type;
        }
    }
}
