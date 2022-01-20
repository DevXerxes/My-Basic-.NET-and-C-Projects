using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing the question for the user
            Console.WriteLine("Guess the location of The Tech Academy?");
            // giving a string variable the value of the user's input (tLoc)
            string tLoc = Console.ReadLine();
            //using boolean data type to provide the true/false results for
            //the switch statement
            bool youCorrect = tLoc == "Portland";

            // using do while statement for the program to run
            // until the correct answer is inputted
            do
            {
                //here is where the loop data is placed
                //within the switch statement (loop)
                //tLoc variable is the data inputted by user
                switch (tLoc)
                {
                    //each case is a potential option that can be inputted
                    case "Houston":
                        Console.WriteLine("You guessed Houston. Try again.");
                        Console.WriteLine("Guess the location of The Tech Academy?");
                        tLoc = Console.ReadLine();
                        //each break tells the program to stop
                        //running the switch statement if the condition is met
                        break;
                    case "New Jersey":
                        Console.WriteLine("You guessed New Jersey. Try again.");
                        Console.WriteLine("Guess the location of The Tech Academy?");
                        tLoc = Console.ReadLine();
                        break;
                    case "Sacramento":
                        Console.WriteLine("You guessed Sacramento. Try again.");
                        Console.WriteLine("Guess the location of The Tech Academy?");
                        tLoc = Console.ReadLine();
                        break;
                    case "Pittsburgh":
                        Console.WriteLine("You guessed Pittsburgh. Try again.");
                        Console.WriteLine("Guess the location of The Tech Academy?");
                        tLoc = Console.ReadLine();
                        break;
                    case "Portland":
                        Console.WriteLine("You guessed Portland. You are a Winner!");
                        youCorrect = true;
                        break;
                    //default is the command that allows the program to provide
                    //a default message after each new input of the user
                    default:
                        Console.WriteLine("Wrong location.");
                        Console.WriteLine("Guess the location of The Tech Academy?");
                        tLoc = Console.ReadLine();
                        break;
                }
            }
            //placed the while statement at end of program
            //to allow the do statement to function correctly
            //while includes symbol "!" that is short for statement "false"
            while (!youCorrect);

            //now using just a while loop
            int m = 1;
            while (m < 11)
            {
                Console.WriteLine(m);
                m++;
            }

            Console.ReadLine();
        }
    }
}
