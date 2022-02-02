using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionApp
{
    class Option
    {
        //public class so its accessible anywhere and data type int=
        // for asking what the result will be
        public int NumOpt(int data, int option = 3)//gave variable "option" a set value so it's made an option
        {
            return data * option;
        }
    }
}
