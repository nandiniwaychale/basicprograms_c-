using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Check Armstrong number : 

namespace Assignments
{
    internal class Armstrong
    {
        int  n,originalnum, rem, res = 0;
        

        public void armNum()
        {
            Console.WriteLine("Enter a Three digit number: ");
            n = Convert.ToInt32(Console.ReadLine());
            originalnum = n;

            while(originalnum != 0)
            {
                rem = originalnum % 10;
                res += rem * rem * rem;
                originalnum /= 10;
            }
            if(res == n)
            {
                Console.WriteLine(n+" Is a Armstrong Number !");
            }
            else
            {
                Console.WriteLine(n + " Is not a Armstrong Number !");
            }
           // return 0;
        }
    }
}
