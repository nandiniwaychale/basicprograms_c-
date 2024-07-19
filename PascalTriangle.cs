using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Print Pascal Triangle : 

namespace Assignments
{
    internal class PascalTriangle
    {
        int l,i,n,s,res;
        public void printPascal()
        {
            Console.WriteLine("Enter n : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(l = 0; l<n;l++)
            {
                for (i = 0;i<=l;i++)
                {
                        Console.Write(coef(l,i)+ " ");
                 }
                      Console.WriteLine("");
            }
        }
        public int coef(int p,int k)
        {
           res = 1;
            if(k > p - k)
            {
                res *= (p - i);
                res /= (i + 1);
            }
            return res;
        }
    }
}
