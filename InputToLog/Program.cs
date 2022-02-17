using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//input the namespace needed to transfer text to files (logging)
using System.IO;

namespace InputToLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user for a number
            Console.WriteLine("Can you enter any number?");
            //logging the users number to a text file using the syntax below
            int urNum = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\vidin\Logs\number.txt", urNum.ToString());
            //raeding and printing text file back to the user
            string urNum2 = File.ReadAllText(@"C:\Users\vidin\Logs\number.txt");
            Console.WriteLine(urNum2);
            Console.ReadLine();


        }
    }
}
