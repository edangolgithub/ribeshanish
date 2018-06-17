using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish
{
     class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //int i = 10;
            //do
            //{

            //    Console.WriteLine(i);
            //    i--;

            //} while (i >= 1);

            int prime = 19;
            bool isprime = false;
            
            for(int i=2; i<=prime-1; i++)
            {
                if(prime%i==0)
                {
                    isprime = false;
                    break;
                }
                else
                {
                    isprime = true;
                }
            }
            if(isprime==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }


       
    }
}
