using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//check leap year : 

namespace Assignments
{
    internal class LeapYear
    {
        int year;
         
        public int checkLeapYear()
        {
            Console.WriteLine("Enter a Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
                Console.ReadLine();
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not a Leap Year!");
                Console.ReadLine();
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a Leap Year!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year!");
                Console.ReadLine();
            }
            return 0;
        }
    }
}
