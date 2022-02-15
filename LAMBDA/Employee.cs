using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Employee
    {
        public Employee(string v1, string v2, int v3)
        {
            firstName = v1;
            lastName = v2;
            Id = v3;
        }

        //two string properties
        //made public to be accessible to any other class
        public string firstName { get; set; }
        public string lastName { get; set; }
        //int method taking in Id for each new employee
        public int Id { get; set; }
    }
}
