using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{  
    internal class Hcf
    {
        int n1, n2,hcf = 1,i;

        public int findhcf()
        {
            Console.WriteLine("Enter Number 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());
             
            for(i=1;i <= n1 || i <= n2;i++)
            {
                if(n1 % i ==0 &&  n2 % i ==0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("HCF Is : "+hcf);
            Console.ReadLine();
            return 0;
        }
    }
}
