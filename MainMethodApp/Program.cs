using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            //entering a number to use for the method in class.cs
            int entNum = 9;
            decimal decNum = 12.5m;
            string stringNum = "7";

            //referencing the data of user input
            //instantiating the class
            var getValue = new Operator();
            //calling the one method then display the integer to screen
            var display = getValue.NumOp(entNum, 6);
            var display2 = getValue.NumOp(decNum, 9.0m);
            var display3 = getValue.NumOp(stringNum, "12");

            //printing returned value (result) to console
            Console.WriteLine("Passed in integers, and returned an integer." + display);
            Console.WriteLine("Passed in decimals, and returned an integer: " + display2);
            Console.WriteLine("Passed in strings, and returned an integer: "+ display3);
            Console.ReadLine();
        }
    }
}
