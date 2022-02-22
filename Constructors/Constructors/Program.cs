using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            //created a const variable so that its value may never be changed
            //by others than the creator
            const string appName = "Example of a constant variable.";

            //creating a variable using the keyword "var"
            var myName = "My name is Marlon";
            Console.WriteLine(appName + myName);
            Console.ReadLine();

            //instantiating the 2nd constructor
            constExample Cost = new constExample();
        }
    }
}
