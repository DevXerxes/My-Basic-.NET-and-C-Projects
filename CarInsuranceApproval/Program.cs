using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval");
            //Asking specific questions using needed 
            //data type for integer,string and boolean
            //age is for integer data type
            Console.WriteLine("What is your age?");
            //taking user input, put into as a variable
            string urAge = Console.ReadLine();
            //casting string response into integer data type
            int whatAge = Convert.ToInt32(urAge);

            //using boolean data type (for comparing values) here
            Console.WriteLine("Have you ever had a DUI? True or False");
            string aDUI = Console.ReadLine();
            //casting string to boolean for true or false responses
            bool youDUI = Convert.ToBoolean(aDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string howMany = Console.ReadLine();
            //casting string to integer to show age number
            int howTickets = Convert.ToInt32(howMany);

            Console.WriteLine("Qualified?");
            //Using the OR operator to capture desired results of program
            //OR operator is true if at least 1 of comparisons is true
            //^ its false if no comparisons is true
            bool carIns = (whatAge > 15 || youDUI == false || howTickets < 3 );
            Console.WriteLine(carIns);

            Console.ReadLine();
        }
    }
}
