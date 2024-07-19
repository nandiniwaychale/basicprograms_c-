using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// factorial of number : 

namespace Assignments
{
    internal class Factorial
    {
        int n, i;
        long fact = 1;

        public int factOfNum()
        {
            Console.WriteLine("Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("We can not find factorial of negative number!");
                Console.ReadLine();
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("Factorial of number " + n + " : " + fact);
                Console.ReadLine();
            }
            return 0;
        }
    }
}
