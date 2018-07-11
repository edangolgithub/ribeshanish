using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.ribesh
{
   public class Ribesh
    {
        public void nestedloop()
        {
            for(int i=0; i<=10; i++)
            {
               for (int j=0; j<=10; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern1()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern2()
        {
            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern3()
        {
            for(int i=5; i>=1; i--)
            {
                for(int j=5; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern4()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=5; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern5()
        {
            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public void pattern6()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern7()
        {
            for(char i= 'A'; i<='E'; i++)
            {
                for(char j= i; j<='E'; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }



    }
}
