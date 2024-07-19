using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ReverseArray
    {
        int[] arr = { 15, 16, 17, 18 };       
       public void reversefun()
        {
            Console.WriteLine("Original Array : ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(arr);

            Console.WriteLine("Reverse Array : ");
            foreach(int j in arr)
            {
                 Console.WriteLine(j); 
            }
            Console.ReadLine();
        }      
    }
}
