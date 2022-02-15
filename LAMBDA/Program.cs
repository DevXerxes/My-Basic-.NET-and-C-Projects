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
            employeesList.Add(new Employee("Joe", "Smith", 4));
            employeesList.Add(new Employee("Bill", "Hunt", 5));
            employeesList.Add(new Employee("Shawn", "Levi", 6));
            employeesList.Add(new Employee("Jenny", "Bogner", 7));
            employeesList.Add(new Employee("Chang", "Rue", 8));
            employeesList.Add(new Employee("Joe", "Smith", 9));
            employeesList.Add(new Employee("Tim", "Turner", 10));
            employeesList.Add(new Employee("Nelly", "Fyiner", 11));
            employeesList.Add(new Employee("Jesse", "Smith", 12));

            //foreach loop to create new list of employees
            //with first name "Joe"
            foreach (Employee employee in employeesList)
            {
                if (employee.firstName == "Joe")
                {
                    Console.WriteLine(employee);
                }
            }
            Console.ReadLine();
        }
    }
}
