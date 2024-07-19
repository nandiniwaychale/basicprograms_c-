using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Date of Birth find Age:

namespace Assignments
{
    internal class DateofBirth
    {
        public void main2()
        {

            Console.WriteLine("Enter your date of birth (yyyy-mm-dd):");
            DateTime dob;

            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid date format. Please enter in yyyy-mm-dd format:");
            }

            int age = calculateAge(dob);

            Console.WriteLine($"Your current age is: {age} years");
        }

        public int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            // Check if the birthday has occurred this year or not
            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
