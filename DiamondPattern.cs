using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//print diamond pattern using nested loop:

namespace Assignments
{
    internal class DiamondPattern
    {
        int space,n,i,j ;
        public void  printDiamondPattrn()
        {
            Console.WriteLine("Enter the number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            space = n - 1;

            for(i=0;i<n;i++)
            {
                for(j = 0;j< space;j++)
                {
                    Console.Write(" ");
                }
                for(j = 0;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                space--;
            }
            space = 0;

            for (i = n; i > 0; i--)
            {
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                space++;
            }
            Console.ReadLine();
        }
    }
}
