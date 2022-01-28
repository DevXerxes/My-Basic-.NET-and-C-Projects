using System;


namespace CallingMethodsApp
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            //asking user for a number to use our methods on
            Console.WriteLine("What number would you like to use for a few math operations to be done with?");
            var userNum = Convert.ToInt32(Console.ReadLine());

            //referencing the object of user input
            var operationObject = new MathMethod();
            //calling the methods by saving it to result variable
            var result = operationObject.AddNum(userNum, 7);
            var result2 = operationObject.SubNum(userNum, 9);
            var result3 = operationObject.MultNum(userNum, 12);
            

            //printing the returned value (result) to console
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
