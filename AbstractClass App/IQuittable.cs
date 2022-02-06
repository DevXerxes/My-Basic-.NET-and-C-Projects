using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_App
{
    //interface created so that as many classes needed can inherit 
    //all methods an properties from this interface
    interface IQuittable
    {
        //void method that has an employee quit
        void Quit(Employee user);
    }
}
