using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the employee class with person properties inherited
            //Employee user = new Employee();
            //a list with 10 employees, 2 with same first name
            List<Employee> employeesList = new List<Employee>();
            //Adding the 10 employees to the list using Add() method
            employeesList.Add(new Employee("Joe", "Smith",1));
            employeesList.Add(new Employee("Maria", "Garcia", 2));
            employeesList.Add(new Employee("Kevin", "Ryder", 3));
            employeesList.Add(new Employee("Joe", "Love", 4));
            employeesList.Add(new Employee("Bill", "Hunt", 5));
            employeesList.Add(new Employee("Shawn", "Levi", 6));
            employeesList.Add(new Employee("Jenny", "Bogner", 7));
            employeesList.Add(new Employee("Chang", "Rue", 8));
            employeesList.Add(new Employee("Joe", "Binst", 9));
            employeesList.Add(new Employee("Tim", "Turner", 10));
            employeesList.Add(new Employee("Nelly", "Fyiner", 11));
            employeesList.Add(new Employee("Jesse", "Smith", 12));

            //foreach loop to create new list of employees
            //with first name "Joe"
            //List<Employee> joesList = new List<Employee>();
            //foreach (Employee employee in employeesList)
            //{
            //    //checking to see if current employee has joe first name
            //    if (employee.firstName == "Joe")
            //    {
            //        //adding joe employee to joesList
            //        joesList.Add(employee);
            //    }
            //}
            ////foreach loop to iterate through joesList and print them to the console
            //foreach (Employee employee in joesList)
            //{
            //    Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);
            //}

            //using LAMBDA expressions to create same joesList
            //and do same task as code above, just shorter
            List<Employee> joesList = employeesList.Where(x => x.firstName == "Joe").ToList();

            //foreach loop to iterate through each employee
            //the print them out to the console
            foreach (Employee employee in joesList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id);
            }


            //LAMBDA expression that makes list of employees
            //with an Id number greater than 5
            List<Employee> aboveFive = employeesList.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in aboveFive)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.Id);
            }

            Console.ReadLine();
        }
    }
}
