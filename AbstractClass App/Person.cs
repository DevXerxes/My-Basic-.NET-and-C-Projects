using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_App
{
    //created an abstract (base) class
    public abstract class Person
    {
        //two string properties of Person class
        //made public to be accessible to any other class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //a method to display the full name on console
        public void SayName()
        {
            string fullName = firstName + lastName;
            //method simply writes person's full name to console
            Console.WriteLine("Name: " + fullName);
        }
    }
}
