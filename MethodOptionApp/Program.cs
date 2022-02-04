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
            //instantiating the Option class
            Option optshin = new Option();
            //letting user know to enter 2 numbers, one at a time
            //2nd entry is optional
            Console.WriteLine("Please enter two numbers, " +
                "\n Enter first one here: ");
            var result = Convert.ToInt32(Console.ReadLine());
            //using a try/catch block to provide a friendly
            //error message of not entering an integer for the second number
            try
            {
                //here user enters 2nd number, which is optional
                Console.WriteLine("Enter second number here, optional, can leave blank: ");
                var result2 = Convert.ToInt32(Console.ReadLine());

                //calling in method from class Option
                var display = optshin.NumOpt(result, result2);

                Console.WriteLine("The result is: " + display);
            }
            catch (Exception)
            {
                Console.WriteLine("It\'s okay, no need to enter a second number.");
                var display = optshin.NumOpt(result);
                Console.WriteLine("The result is: " + display);
            }
            
            Console.ReadLine();
        }
    }
}
