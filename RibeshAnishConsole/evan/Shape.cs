using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.evan
{
    class Shape
    {
        public double length;
        public double breadth;
        public void calculatearea()
        {
            Console.WriteLine("area of shape");
        }
    }
    class Triangle:Shape
    {
        public Triangle()
        {
             
        }

        public new void calculatearea()
        {
            double area = 0.5 * length * breadth;
            Console.WriteLine(area);
        }
    }
    class Rectangle:Shape
    {
        
        public Rectangle()
        {
            
        }
        public new void calculatearea()
        {
            Console.WriteLine( length * breadth);
        }
    }

    class Square: Rectangle
    {
        public Square()
        {
            
        }
        public new  void calculatearea()
        {
            Console.WriteLine( length * length);
        }
    }
}
