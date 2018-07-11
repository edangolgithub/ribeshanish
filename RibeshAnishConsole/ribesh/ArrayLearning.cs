using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibeshAnishConsole.ribesh

{
    class ArrayLearning
    {
       
        int[] arr = { 1, 2, 3, 4, 8 };

        public void showarray()
        {
        
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
           
        }
            public void  search(int num)
        {
            bool flag = false;
            for(int i=0; i<arr.Length; i++)
            {
                if(num==arr[i])
                {
                    flag = true;
                    break;
                }



            }   
            if(flag==true)
            {
                Console.WriteLine("exists");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public void findindex(int num)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    Console.WriteLine(i);
                        
                    break;
                }



            }
          
        }

        public void findproduct()
        {
            double product = 1;
            for (int i = 0; i < arr.Length; i++ )

            {
                product = product * arr[i];
            }

            Console.WriteLine(product);
        } 

        


    }
}
