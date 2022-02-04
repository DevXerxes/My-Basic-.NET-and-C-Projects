using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKnowledge
{
    class AllIn
    {
        //void method outputting an integer, dividing data passed to it by 2
        public void OutVoid(int data)
        {
            Console.WriteLine(data / 2);
        }

        //creating a method with output parameters
        public void getValues(out int m, out int n)
        {
            m = 22;
            n = 24;
        }
        //overloading a method 
        public void getValues(int h, int i)
        {
            h = 22;
            i = 24;
            Console.WriteLine(h * i);
        }
        //declaring a class to be static
        public static class MathOp
        {
            public static int NumNums(int b, int a)
            {
                b = 9;
                a = 8;
                return b * a;
            }
        }
    }
}
