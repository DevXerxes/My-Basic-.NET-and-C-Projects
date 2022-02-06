using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_App
{
    //made class employee inherit from Person class
    //employee class can now use properties of Person class
    class Employee : Person, IQuittable
    {
        //implementing SayName method from Person abstract class
        //a method to display the full name on console
        public void SayName()
        {
            string fullName = firstName + lastName;
            //method simply writes person's full name to console
            Console.WriteLine("Name: " + fullName);
        }
        //using the interface method here in a way i chose
        void IQuittable.Quit(Employee user)
        {
            if (user.firstName == "Sample")
            {
                Console.WriteLine("This employee " + firstName + " wants to quit.");
            }
        }
    }
}
