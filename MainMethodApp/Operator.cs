using System;

namespace MainMethodApp
{
    class Operator
    {
        //a public method to be accessible anywhere on console app
        // this method takes in an integer and adds it with another
        //then returns result as an integer
        public int NumOp(int data, int value)
        {
            return data + value;
        }

        //2nd method with same name but different math operation (decimal integer)
        public decimal NumOp(decimal data, decimal value)
        {
            return data - value;
        }

        //3rd method with same name, taking in string and displaying
        // result as an integer
        public string NumOp (string data, int value)
        {
            return Int32.TryParse(data) * value;
        }
    }
}
