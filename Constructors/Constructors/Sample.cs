using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class constExample
    {
        public constExample(): this(22)
        {
            //No parameter constructor method.// 1st
        }

        public constExample(int Age)
        {
            //Constructor with one parameter.// 2nd
        }
    }
}
