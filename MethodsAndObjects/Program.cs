using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the employee class
            Employee person = new Employee();
            //intializing an object with the Person's class properties
            //(firstname and lastname) inherited by Employee class
            person.FirstName = "Sample ";
            person.LastName = "Student";

            //calling the superclass (method from class thats inheriting from another class)
            //Person method SayName to print employee object name in full
            person.SayName();
            Console.ReadLine();
        }
    }
}
