using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            AllIn todo = new AllIn();
            //asking user to enter a number
            Console.WriteLine("Please enter a number: ");
            int userIn = Convert.ToInt32(Console.ReadLine());
            //calling method on the user's number
            todo.OutVoid(userIn);
            //printing the output to the screen
            Console.ReadLine();
        }
    }
}
