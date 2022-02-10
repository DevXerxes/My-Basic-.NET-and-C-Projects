using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator___
{
    class Employee : Person, IQuittable
    {
        //int method taking in Id for each new employee
        public int Id { get; set; }

        //implementing SayName method from Person abstract class
        //a method to display the full name on console
        public void SayName()
        {
            string fullName = firstName + lastName;
            //method simply writes person's full name to console
            Console.WriteLine("Name: " + fullName);
        }
        //using the interface method here in a way i chose
        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }

        //overloading the "==" operator to check 
        //if two Employee objects are equal, comparing their Id property
        public static Person operator== (Employee user, Person person)
        {
            user.Id.CompareTo(user.Id);
            return user;
        }

        public static Person operator!= (Employee user, Person person)
        {
            user.Id.CompareTo(user.Id);
            return user;
        }
    }
}
