using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassApp
{
    class Void
    {
        //creating void (returns no result) method with two integers as parameters
        public void NumVoid(int a, int b)
        {
            //first num just takes a math operation, no display
            int operation = a * b;
            //2nd num displays given integer only
            Console.WriteLine(b);
        }
    }
}
