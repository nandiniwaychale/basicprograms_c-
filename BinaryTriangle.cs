using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// print Binary Triangle :

namespace Assignments
{
    internal class BinaryTriangle
    {
        int row, col,n;
        public void printBinary()
        {
            Console.WriteLine("Enter number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (row = 0; row < n; row++)
            {
                for(col = 0; col <= row; col++)
                {
                    if(((row + col)% 2) == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine("\t");
            }
        }
    }
}
