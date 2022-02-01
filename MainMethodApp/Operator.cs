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
        public int NumOp(decimal data, decimal value)
        {
            return Convert.ToInt32(data - value);
        }

        //3rd method with same name, taking in string and displaying
        // result as an integer
        public int NumOp (string data, string value)
        {
            int answer = Int32.Parse(data);
            int answer2 = Int32.Parse(value);
            return answer * answer2;
        }
    }
}
