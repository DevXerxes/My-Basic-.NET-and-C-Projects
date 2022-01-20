using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //concatenating (adding words together) 3 strings
            string one = "Hello, ";
            string two = "my name is ";
            string three = "Marlon.";
            //using the "+" sign to concatenate the strings
            //using ToUpper command to print the string attached to it
            //as all uppercased letters
            Console.WriteLine(one + two + three.ToUpper());

            //using StringBuilder to allows a developer to 
            //add new lines of code, in this case strings, to existing lines of code (strings)
            StringBuilder aboutMe = new StringBuilder();

            //using Append() to tell computer to add new lines
            //of code to existing code
            //used \n to add new strings on new line
            aboutMe.Append("I am a Software Developer in the making." +
                "\nChallenges are welcome by me, cause they stretch my strength." +
                "\nI am ready to build more complex programs and softwares.");
            Console.WriteLine(aboutMe);

            Console.ReadLine();
        }
    }
}
