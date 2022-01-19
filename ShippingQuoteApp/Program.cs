using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro of program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //asking user for weight of package
            Console.WriteLine("Please enter the package weight: ");
            //acquire inputted weight using an integer(string casted into int data type)
            //variable to hold that user input(value)
            int pWeight = Convert.ToInt32(Console.ReadLine());
            //using if statement to check user input is
            //in the accept zone
            if (pWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //asking for package width, doing same process for weight prompt
                Console.WriteLine("Please enter the package width:");
                int pWidth = Convert.ToInt32(Console.ReadLine());
                //asking for package height, doing same process for weight prompt
                Console.WriteLine("Please enter the package height:");
                int pHeight = Convert.ToInt32(Console.ReadLine());
                //asking for package length, doing same process for weight prompt
                Console.WriteLine("Please enter the package width:");
                int pLength = Convert.ToInt32(Console.ReadLine());
                int sum = pWidth + pLength + pHeight;
                if (sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    //multiplying the 3 dimesions together: height, width and length
                    decimal triMult = pWidth * pHeight * pLength;
                    //multplying product of triMult by the weight of package
                    decimal product = triMult * pWeight;
                    //dividing outcome of product operation to get quote of shipping costs
                    decimal result = product / 100.00m;

                    //convert result of quote math operations
                    //to decimal form (20.00)
                    int total = 1;
                    decimal quote = result * total;
                    //multiply end product by decimal data type (Ex: 1.00m)
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote * 1.00m);
                    Console.WriteLine("Thank you!");
                }
            }

            Console.ReadLine();
        }
    }
}
