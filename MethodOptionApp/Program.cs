using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using a try/catch block to provide a friendly
            //error message of not entering an integer for the second number
            try
            {
                //instantiating the Option class
                Option optshin = new Option();
                //letting user know to enter 2 numbers, one at a time
                //2nd entry is optional
                Console.WriteLine("Please enter two numbers, " +
                    "\n Enter first one here: ");
                var result = Convert.ToInt32(Console.ReadLine());
                //here user enters 2nd number, which is optional
                Console.WriteLine("Enter second number here, optional, can leave blank: ");
                var result2 = Convert.ToInt32(Console.ReadLine());

                //calling in method from class Option
                var display = optshin.NumOpt(result, 6);
                var display2 = optshin.NumOpt(result2);

                Console.WriteLine("Your first number result is: " + display);
                Console.WriteLine("Your second number result is: " + display2);
            }
            catch (Exception)
            {
                Console.WriteLine("It\'s okay, no need to enter a second number.");
            }
            
            Console.ReadLine();
        }
    }
}
