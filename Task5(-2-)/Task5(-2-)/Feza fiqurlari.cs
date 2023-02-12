using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task5__2__
{
    public abstract class Feza_fiqurlari
    {
        public const double pi = 3.14;
        protected double a;
        protected double b;
        public Feza_fiqurlari (double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract double area();
        public abstract double Volume();
        public override string ToString()
        {
            return $@"<<{this.GetType().Name}>>
                         area:{this.area()}
                       Volume: {this.Volume()}";
        }
    }




    
}
