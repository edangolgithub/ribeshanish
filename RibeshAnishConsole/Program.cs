using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvanDangol.Tutorial.General;
using RibeshAnishConsole.evan;
namespace RibeshAnishConsole
{
    class Program
    {
        int[] a = { 0, 1, 2, 3,4 };
        enum days { sun, mon,tue,wed,thu,fri, sat};
        static void Main(string[] args)
        {
            Square s = new Square();
            s.length = 2;
            s.calculatearea();

            Rectangle r = new Rectangle();
            r.length = 40;
            r.breadth = 20;
            r.calculatearea();

            Triangle t = new Triangle();
            t.length = 21;
            t.breadth = 13;
            t.calculatearea();

            Shape ss = new Shape();
            ss.length = 30;
            ss.breadth = 50;
            ss.calculatearea();
        }

        
    }
}
