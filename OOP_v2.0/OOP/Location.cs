using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Location
    {
        public double Distance
        {
            get; set;
        }
        public double Redshift
        {
            get; set;
        }
        
        public Location(double distance, double redshift)
        {
            Distance = distance;
            Redshift = redshift;
        }
    }
}
