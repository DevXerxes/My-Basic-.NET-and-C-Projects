using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking in input and multiplying it by 50
            //using int data type
            Console.WriteLine("Enter your number please: ");
            string userInput = Console.ReadLine();
            //Casting string to a int data type to be displayed
            int userNum = Convert.ToInt32(userInput);
            int product = userNum * 50;
            Console.WriteLine("Your input multiplied by 50 is: " + product);

            //taking an input by user and adding 25 to it
            //using the plus math operator
            Console.WriteLine("Enter your desired number: ");
            string addNum = Console.ReadLine();
            //Casting string to a int data type to be displayed
            int urDigit = Convert.ToInt32(addNum);
            int total = urDigit + 25;
            Console.WriteLine("Your number added by 25 is: " + total);

            //taking an input and dividing it by 12.5
            //using the double data type
            Console.WriteLine("Enter your number: ");
            string quoNum = Console.ReadLine();
            //Casting string to a double data type to be displayed
            double urDec = Convert.ToDouble(quoNum);
            double quotient = urDec / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);

            //taking an input to check it if its greater than 50
            //using the boolean data type, true or false
            Console.WriteLine("Enter your number so we can compare it: ");
            string theNum = Console.ReadLine();
            //casting the input string into integer
            int theInput = Convert.ToInt32(theNum);
            //casting the integer into boolean logic
            //comparing if the input id greater than or equal to 50
            bool comparison = theInput >= 50;
            Console.WriteLine("Is your number greater than 50? True or False: " + comparison);

            //taking an input dividing it by 7
            //then print the remiander on console using the "%" symbol
            Console.WriteLine("Enter your number to see if it has a remainder after divided by 7: ");
            string leftOver = Console.ReadLine();
            int remainder = Convert.ToInt32(leftOver);
            int theAnswer = remainder / 7;
            int lastOne = remainder % theAnswer;
            Console.WriteLine("Your remainder of your number divided by 7 is :" + lastOne);
            Console.ReadLine();
        }
    }
}
