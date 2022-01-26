using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //using try/catch block to catch any erros
        //and display a friendly error message to users
        try
        {
            // list of integers
            List<int> divideNums = new List<int>()
        {
            64,
            56,
            112,
            24,
            82
        };
            //asking user for a number to use for
            //dividing it by all the integers in the list
            Console.WriteLine("Can you provide any number?");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //using foreach loop to each integer in list
            //and divide it by number entered by user
            foreach (int Num in divideNums)
            {
                //displaying each result on the console
                Console.WriteLine("List number divided by your number equals: " + Num / userNum);
            }
            Console.ReadLine();
        }
        //catch block to let user know to enter 
        //whole numbers, not strings(words)
        catch (FormatException ex)
        {
            Console.WriteLine("Please type in a whole number.");
            return;
        }
        //catch block to display error message 
        //for using zeros to divide with
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don\'t divide by zero.");
        }
        //catch block to catch any error and display
        //the proper error message according to the input
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //finally block to always display the message below
        finally
        {
            Console.WriteLine("Program has emerged from try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
        
    }
}
