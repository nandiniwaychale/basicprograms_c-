using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Gcd
    {
        int n1, n2, i, gcd;

        public int findGcd()
        {
            Console.WriteLine("Enter Number 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            for(i = 1;i <=n1 && i <=n2; ++i)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    gcd = i;
            }
            Console.WriteLine("GCD is: "+gcd);
            Console.ReadLine();
            return 0;
        }
    }
}
