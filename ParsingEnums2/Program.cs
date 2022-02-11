using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    //created an enum for the days of the week
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)
    {
        //prompting user to enter current day of the week
        Console.WriteLine("Enter the current day of the week: ");
        //parsing the enum to properly take in string values 
        //in a try/catch block to display a friendly error message
        try
        {
            //assigning user value to variable of that enum data type created
            string urDay = Console.ReadLine();
            Enum.Parse(typeof(DaysOfTheWeek), urDay);
        }
        //catch block to catch any error and display the below message
        catch (Exception)
        {
            Console.WriteLine("Please enter an actual day of the week.");
        }
        Console.ReadLine();
    }
}
