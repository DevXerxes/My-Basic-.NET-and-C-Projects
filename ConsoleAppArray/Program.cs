using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //one-dimensional(a single row of strings) array of strings
        string[] carMake = { "Toyota", "Honda", "Mercedes", "Dodge", "Ford" };
        //asking user to select an index of the given array
        Console.WriteLine("Choose a number 0-4 to see what type of Car you get.");
        //read user input for the index as an int
        //because an index is a number
        int yourCar = Convert.ToInt32(Console.ReadLine());
  
        //using if statement to print an error message
        //if user inputs an index that doesnt exist in the array
        if (yourCar > 4)
        {
            Console.WriteLine("That choice does not exist. Try again.");
        }
        else
        {
            //reference that user index number of the array with code below
            Console.WriteLine(carMake[yourCar]);
        }

        //one-dimensional(a single row of strings) array of integers
        int[] guessNum = { 18, 29, 45, 22, 23, 32 };
        //asking user to select an index of the given array
        Console.WriteLine("Choose a number 0-5 for a random lucky number.");
        //read user input for the index as an int
        //because an index is a number
        int trueNum = Convert.ToInt32(Console.ReadLine());

        //using if statement to print an error message
        //if user inputs an index that doesnt exist in the array
        if (trueNum > 5)
        {
            Console.WriteLine("That choice does not exist. Try again.");
        }
        else
        {
            //reference that user index number of the array with code below
            Console.WriteLine(guessNum[trueNum]);
        }



        //Creating a list of strings
        List<string> compList = new List<string>();
        //use your list name with the .Add command
        //to add your elements to your list
        compList.Add("Intelligent");
        compList.Add("Attractive");
        compList.Add("Cool");
        compList.Add("Strong");
        //asking user to select an index of the list
        Console.WriteLine("Choose a number from 0 to 3 to recieve a nice compliment.");
        //read user input for the index as a int
        int numComp = Convert.ToInt32(Console.ReadLine());

        //using if statement to print an error message
        //if user inputs an index that doesnt exist in the array
        if (numComp > 3)
        {
            Console.WriteLine("That choice does not exist. Try again.");
        }
        else
        {
            //reference that user index number of the array with code below
            Console.WriteLine(compList[numComp]);
        }

        Console.ReadLine();
    }
}

