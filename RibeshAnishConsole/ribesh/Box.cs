using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.ribesh
{
    class Box
    {
        private double a;
        private double b;
        private double c;

        public Box()
        {
            a = 20;
            b = 30;
            this.c = 10;
        }

        public Box(double length, double b, double height)
        {
            this.a = length;
            this.b = b;
            this.c = height;
        }

        public void CalculateArea()
        {
            double area = a * b;
            Console.WriteLine("area is  " + area);
        }

        public void CalculateVolume()
        {
            double volume = a * b * c;
            Console.WriteLine("volume is  " + volume);
        }

        public void CalculateTSA()
        {
            double TSA = (2 * a * b) + (2 * b * c) + (2 * a * c);
            Console.WriteLine("TSA is  " + TSA);
        }

        public void CalculateLSA()
        {
            double LSA = 4 * a * a;
            Console.WriteLine("LSA is " + LSA);
        }

        public void CalculatePerimeter()
        {

        }



    }
}
