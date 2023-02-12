using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5__2__
{
    internal class Duzbucaqlı_Paralelepiped:Feza_fiqurlari
    {
        private double c;
        public Duzbucaqlı_Paralelepiped(double a,double b,double c):base(a,b)
        {
            this.c = c;
        }
        public override double area()
        {
           double area=2*(a*b+a*c+b*c);
            return area;
        }
        public override double Volume()
        {
            double volume = a * b * c;
            return volume;
        }
    }
}
