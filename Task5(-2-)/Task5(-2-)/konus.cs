using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5__2__
{
    internal class konus:Feza_fiqurlari
    {
    
        public konus(double height,double radius):base(height,radius)
        {

        }
        public override double area()
        {
            double area = pi * b * b;
            return area;
        }
        public override double Volume()
        {
           
            double volume = Math.Round((pi * b * b*a/3),2);
            return volume;
        }


    }
}
