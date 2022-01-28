using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsApp
{
    public class MathMethod
    {
        //setting methods public to be accessible anywhere
        //first method is adding integers
        public int AddNum(int data, int value)
        {
            
            return data + value;
        }
        //2nd method subtracting integers
        public int SubNum(int data, int value)
        {
            
            return data - value;
        }
        //3rd method multiplies integers
        public int MultNum(int data, int value)
        {
            return data * value;
        }
    }
}
