using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        //giving this class two properties to use for
        //holding values
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //created a void method with no parameters 
        public void SayName()
        {
            string fullName = FirstName + LastName;
            //method simply writes person's full name to console
            Console.WriteLine("Name: " + fullName);
        }
    }
}
