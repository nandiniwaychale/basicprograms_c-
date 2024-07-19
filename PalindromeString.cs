using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class PalindromeString
    {
        string str = string.Empty,str1 = string.Empty;
        int i,l;
        string c;
        public void stringOperation()
        {
            Console.WriteLine("Enter a String : ");
            str = Console.ReadLine();

            l = str.Length;

            Console.WriteLine("Length of String is : " +l);

            for (i = str.Length-1;i >= 0; i--)
            {
                str1 += str[i];
            }
            Console.WriteLine("Reverse String is : "+str1);
            Console.ReadLine();

            if(str == str1)
            {
                Console.WriteLine("String is Palindrome!");
            }
            else
            {
                Console.WriteLine("String is not Palindrome!");
            }
        }
    }
}
