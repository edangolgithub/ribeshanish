using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvanDangol.Tutorial.General;
using RibeshAnishConsole.ribesh;
namespace RibeshAnishConsole
{
    class Program
    {

        enum days { sun ,mon ,tue ,wed ,thur ,fri ,sat}
        static void Main(string[] args)
        {
            square s = new square();
            s.length = 4;
            s.calculatearea();

            rectangle r = new rectangle();
            r.length = 25;
            r.breadth = 20;
            r.calculatearea();

            triangle t = new triangle();
            t.length = 15;
            t.breadth = 10;
            t.calculatearea();

            Shape ss = new Shape();
            ss.length = 20;
            ss.breadth = 30;
            ss.calculatearea();
        }

       

        
    }
}
