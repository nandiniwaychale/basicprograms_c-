using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Lcm
    {
        int n1, n2, max;
    
         public int findLcm()
        {
            Console.WriteLine("Enter positive Number 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Positive Number 2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            max = (n1 > n2) ? n1 : n2;

            while(n1 > 0)
            {
                if((max % n1 ==0) && (max % n2 ==0))
                {
                    Console.WriteLine("LCM is : " + max);
                    Console.ReadLine();
                    break;
                }
                ++max;
            }
           return 0;
        }
    }
}
