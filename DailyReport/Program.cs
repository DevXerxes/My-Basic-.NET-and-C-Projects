using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a line for intro of program and
            //told program to keep the command prompt open with result
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //code that asks and saves data according
            //to its proper data type
            Console.WriteLine("What is your name?");
            //using string data type
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is: " + userName);

            Console.WriteLine("What course are you on?");
            //using string data type
            string courseType = Console.ReadLine();
            Console.WriteLine("Your course is: " + courseType);

            //using the integer data type, casting string to integer
            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            int whatPage = Convert.ToInt32(pageNum);
            Console.WriteLine("You are on Page number: " + whatPage);

            //using the boolean data type, casting from string to boolean
            Console.WriteLine("Do you need help with anything? True or False");
            string youNeedHelp = Console.ReadLine();
            bool needhelp = Convert.ToBoolean(youNeedHelp);
            Console.WriteLine(needhelp);

            //using string data type for a longer text
            Console.WriteLine("Were there any positive experiences you\'d like to share?");
            string urExp = Console.ReadLine();
            Console.WriteLine("Here\'s what you shared: " + urExp);

            //using string data type for a longer text
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string urFeedback = Console.ReadLine();
            Console.WriteLine("Here\'s what you shared: " + urFeedback);

            //Here we use the decimal data type for exact hours and minutes
            Console.WriteLine("How many hours did you study today?");
            string hoursIs = Console.ReadLine();
            decimal studyHours = Convert.ToDecimal(hoursIs);
            Console.WriteLine("Hours studied: " + studyHours);

            //the end of the program
            Console.WriteLine("Thank you for your answers. An Instructor will " +
                "respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
