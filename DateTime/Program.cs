using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datetime
{
    public class Program
    {
        static void Main(string[] args)
        {
            //printing current date and time to console
            Console.WriteLine("Current Date and Time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            //asking user for a number
            Console.WriteLine("Enter any number: ");
            int urNum = Convert.ToInt32(Console.ReadLine());
            //printing the exact hour the user entered their number to the console
            DateTime urNum2 = DateTime.Now;
            DateTime addedUrHours = urNum2.AddHours(urNum);
            //"h tt" h prints the hour and tt prints the time as day or night
            Console.WriteLine("Time of your input:{0}", addedUrHours);
            
            


            Console.ReadLine();

        }
    }
}
