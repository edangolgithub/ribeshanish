using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibeshAnishConsole.evan;
namespace RibeshAnishConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 72, 98 };
            int[] arrr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arrr[i] = 4+i;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrr[i]);
            }
            //array();
        }

        public static void array()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int[] arrr = new int[7];
            for(int i=0; i<7; i++)
            {
                arrr[i] = 5 + i;
            }
            for(int i=0; i<7; i++)
            {
                Console.WriteLine(arrr[i]);
            }
        }
    }
}
