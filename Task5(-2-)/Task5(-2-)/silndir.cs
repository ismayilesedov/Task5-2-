using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5__2__
{
    internal class silndir:konus
    {
        public silndir (double height,double radius) : base(height, radius)
        {

        }
        public override double area()
        {
            double circlearea = pi * Math.Pow(b, 2);
            double area = 2 * circlearea * 2 * pi * b * a;
            return area;
        }
        public override double Volume()
        {
            double volume = pi * Math.Pow(b, 2) * a;
            return volume;
        }
    }
}
