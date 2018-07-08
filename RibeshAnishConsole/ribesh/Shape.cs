using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.ribesh
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

    class triangle:Shape
    {
        public triangle()
        {

        }

        public new void calculatearea()
        {
            Console.WriteLine(0.5 * length * breadth);
        }  

            
    }

    class rectangle : Shape
    {
        public new void calculatearea()
        {
            Console.WriteLine(length * breadth);
        }
    }

    class square:rectangle
    {
        public new void calculatearea()
        {
            Console.WriteLine(length * length);
        }
    }

    
        


}
