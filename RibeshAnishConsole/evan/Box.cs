using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.evan
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public Box()
        {
           this.length = 20;
            breadth = 30;
            this.height = 10;
        }

        public Box(double length, double b, double height)
        {
            this.length = length;
            this.breadth = b;
            this.height = height;
        }

        public void CalculateVolume()
        {
            double area = length * breadth;
            Console.WriteLine("area is " + area);
            Console.WriteLine(length * breadth * height);
        }


    }
}
