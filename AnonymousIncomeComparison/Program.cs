using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title of program
            Console.WriteLine("Anonymous Income Comparison Program");

            //the info of first Person, hourly rate and hours worked a week
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate: ");
            string person1 = Console.ReadLine();
            //casting a string into a decimal to enter the hourly rate
            //including half of hours or 3 quarters etc
            int hourlyRate = Convert.ToInt32(person1);
            Console.WriteLine("Your hourly rate is: " + hourlyRate + "$ per hour.");
            Console.WriteLine("Please enter thee exact hours you worked this week: ");
            string perWeek = Console.ReadLine();
            //casting string into a double data type to
            //allow input of excat hours and minutes a week worked
            int hoursPerWeek = Convert.ToInt32(perWeek);
            Console.WriteLine("You worked " + hoursPerWeek + " hours this week.");

            //the info of second Person, hourly rate and hours worked a week
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate: ");
            string person2 = Console.ReadLine();
            //casting a string into a decimal to enter the hourly rate
            //including half of hours or 3 quarters etc
            int hourlyRate2 = Convert.ToInt32(person2);
            Console.WriteLine("Your hourly rate is: " + hourlyRate2 + "$ per hour.");
            Console.WriteLine("Please enter thee exact hours you worked this week: ");
            string perWeek2 = Console.ReadLine();
            //casting string into a double data type to
            //allow input of excat hours and minutes a week worked
            int hoursPerWeek2 = Convert.ToInt32(perWeek2);
            Console.WriteLine("You worked " + hoursPerWeek2 + " hours this week.");

            //Using multiplication to get exact annual rate of Person 1
            int product = hourlyRate * hoursPerWeek;
            int finalRate = product * 53;
            Console.WriteLine("Annual salary of Person 1: " + finalRate);

            //Using multiplication to get exact annual rate of Person 1
            int product2 = hourlyRate2 * hoursPerWeek2;
            int finalRate2 = product2 * 53;
            Console.WriteLine("Annual salary of Person 2: " + finalRate2);

            //using boolean logic to check which person,
            //makes the most money annually
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparisonRate = finalRate >= finalRate2;
            Console.WriteLine(comparisonRate);

            Console.WriteLine("Thank you for cooperating. Have a great day!");
            Console.ReadLine();
        }
    }
}
