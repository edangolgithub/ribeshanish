using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribeshanish.Ribesh
{
    class Pyramid
    {

        private double slantheight;
        private double height;
        private double basearea ;
        private object s;
        private double h;
        private double a;

        public Pyramid ()
        {
            slantheight = 8;
            height = 7;
            basearea = 12;
        }

        public Pyramid(double s,double h, double a)
        {
            this.s = slantheight;
            this.h = height;
            this.a = basearea;
        }

        public void CalculateVolume()
        {
            double volume = (1 / 3) * basearea * height;
            Console.WriteLine("the volume of pyramid is " + volume);
        }


    }
}
