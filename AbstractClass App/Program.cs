using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an Employee object
            Employee user = new Employee();
            //here is the values of that object
            user.firstName = "Sample ";
            user.lastName = "Student";
            //calling SayName method on object
            user.SayName();

            Console.ReadLine();
        }
    }
}
