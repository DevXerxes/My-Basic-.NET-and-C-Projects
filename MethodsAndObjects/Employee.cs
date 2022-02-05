using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //this class Employee is inheriting from the class Person
    //it comes with all the properties and methods 
    class Employee : Person
    {
        //created a property that recieves and gives
        //an integer referencing an Id number
        public int Id { get; set; }
    }
}
