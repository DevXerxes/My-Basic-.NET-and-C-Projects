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
            Console.WriteLine("Enter a number: ");
            var entNum = Convert.ToInt32(Console.ReadLine());
            decimal decNum = 12.5m;

            //referencing the data of user input
            //instantiating the class
            var getValue = new Operator();
            //calling the one method then display the integer to screen
            var display = getValue.NumOp(entNum, 6);
            var display2 = getValue.NumOp(decNum, 9.0m);
            var display3 = getValue.NumOp(entNum, 12);

            //printing returned value (result) to console
            Console.WriteLine(display);
            Console.WriteLine(display2);
            Console.WriteLine(display3);
            Console.ReadLine();
        }
    }
}
