using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.ribesh
{
    class Maths
    {
        public double firstnum;
        public double secondnum;


        public void add()
        {
            Console.WriteLine(firstnum + secondnum);

        }
        public void divide()
        {
            Console.WriteLine(firstnum / secondnum);

        }
        public void multiply()
        {
            Console.WriteLine(firstnum * secondnum);
        }
        public void subtract()
        {
            Console.WriteLine(firstnum - secondnum);

        }
        public void fibonacci()
        {
            int a;
            int b;
            int c;
            a = 0;
            b = 1;
            for (int i = 0; i <= 25; i++)

            {

                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c; }
        }

            


            public void even() 
        {

            for (int i = 0; i <= 10; i++)
                if (i % 2 == 0)

                {
                    Console.WriteLine(i);
                }


            int p = 12;
            int v = 0;
            for(int i=2; i<=10; i++)
            {
                if(p%i==0)
                {
                    v = 0;
                    break;
                   // Console.WriteLine("it is not prime");
                }
                else
                {
                    v = 1;
                    //Console.WriteLine("it is prime");
                }
            }

            if(v==0)
            {
                Console.WriteLine("it is not prime");
            }
            else
            {
                Console.WriteLine("it is prime");
            }
        }



    }
}
