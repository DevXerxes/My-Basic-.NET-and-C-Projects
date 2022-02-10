using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator___
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphing the inherited classes 
            Person person = new Employee();
            Employee user = new Employee();
            //creating employee objects to compare
            person.firstName = "Norma";
            person.firstName = "Marlon";
            //comparing the objects if they're equal
            var one = user == person;
            var two = user != person;
            Console.WriteLine(one + "\ntwo");

            Console.ReadLine();


        }
    }
}
