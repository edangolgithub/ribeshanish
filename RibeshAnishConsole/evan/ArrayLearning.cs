using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.evan
{
    class ArrayLearning
    {
       
        int[] firstarray = { 1, 2, 3, 4, 8 };

        int[] secondarray;
        public void showarray()
        {
        
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(firstarray[i]);
            }
           
        }

        public void search(int num)
        {
            bool flag = false;
            for (int i = 0; i < firstarray.Length; i++)
            {
                if(num==firstarray[i])
                {
                    flag = true;
                    break;
                }
            }

            if(flag==true)
            {
                Console.WriteLine("exist");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public void findindex(int num)
        {
            
            for (int i = 0; i < firstarray.Length; i++)
            {
                if (num == firstarray[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            
        }

        public void findaverage()
        {
            
            double sum = 0;
            for (int i = 0; i < firstarray.Length; i++)
            {
                sum = sum + firstarray[i];
            }
            double n = firstarray.Length;
            double ave = sum / n;
            Console.WriteLine(ave);
        }

        public void findproduct()
        {
            double product = 1;

            for (int i = 0; i < firstarray.Length; i++)
            {
                product = product * firstarray[i];
            }
            Console.WriteLine(product);
        }

        public void reversearray()
        {
            secondarray = new int[firstarray.Length];

            for (int i = 0; i < firstarray.Length; i++)
            {
                secondarray[i] = firstarray[i];
            }


            for (int i = 0; i < secondarray.Length; i++)
            {
                Console.WriteLine(secondarray[i]);
            }

            int a = 0;
            int b = firstarray.Length - 1;
            for (int i = 0; i < secondarray.Length; i++)
            {
                secondarray[a] = firstarray[b];
                a++;
                b--;
            }

            for (int i = 0; i < secondarray.Length; i++)
            {
                Console.WriteLine(secondarray[i]);
            }
        }

    }
}
