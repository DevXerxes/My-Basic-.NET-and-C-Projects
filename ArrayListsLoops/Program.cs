using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //a one-dimensional array of strings
        string[] names = { "Norma", "Marlon", "Erik", "Janet", "Montse" };

        //asking user to input some text
        Console.WriteLine("Can you input a compliment for the following names?");
        string compliment = Console.ReadLine();

        //loop that iterates through each string in array
        // and adds the users text input to end of each string
        // and does not output to console but updates each array
        // element by appending users text

        for (int m = 0; m < names.Length; m++)
        {
            names[m] += compliment;
            Console.WriteLine(names[m]);

        }

        // Creating infinite loop
        // using while loop
        //while (true)
        //{
        //    //This statement will be printed infinite times
        //    Console.WriteLine("You are all great!");
        //}

        // Code below is how to fix an infinite loop
        // so it executes properly
        string urState = "You are all great!";
        while (!false)
        {
            if (urState == "You are all great!")
            {
                Console.WriteLine(urState);
                // using break to stop a loop from printing infinitely
                break;
            }
            else
            {
                Console.WriteLine("That is the incorrect input.");
            }
        }

        Console.WriteLine("A loop using the < operator:");
        //new integer array
        int[] ranNums = { 45, 63, 54, 98, 72 };
        // a for loop with comparison is determined
        // whether to continue iterating loop is a "<" operator
        for (int n = 0; n < ranNums.Length; n++)
        {
            if (ranNums[n] < 70)
            {
                Console.WriteLine(ranNums[n]);
            }
        }

        Console.WriteLine("A loop using the <= operator:");
        // a for loop where comparison used by "<=" operator determines 
        // if to continue iterating through loop
        for (int m = 0; m <=5; m++)
        {
            
             Console.WriteLine(m);
            
        }


        // A list of strings with unique items in it
        List<string> urAnimal = new List<string>();
        urAnimal.Add("dog");
        urAnimal.Add("cat");
        urAnimal.Add("bird");
        urAnimal.Add("reptile");
        // asking user to input text that searches for in the list
        Console.WriteLine("Enter your favorite class of animal to search the list: ");
        string animalName = Console.ReadLine();

        //foreach loop that iterates through list
        // and displays the index of the list
        // that contains matching text on screen
        foreach (string animal in urAnimal)
        {

            if (urAnimal.Contains(animalName) == false)
            {
                Console.WriteLine("Sorry, your animal is not on the list.");
                break;
            }
            else if (animal == animalName)
            {
                //displaying index
                Console.WriteLine("Your animal is found at index: " + urAnimal.IndexOf(animal));
                break;
            }

            
        }



        //list of strings with 4 identical strings in list
        List<string> foodSpots = new List<string>()
        {
            "InnOut",
            "Mcdonalds",
            "InnOut",
            "Jack in the Box",
            "Taco Bell",
            "Jack in the Box",
            "InnOut"
        };
        //asking user to select text to search for in list
        Console.WriteLine("Select a Fast food spot that\'s your favorite: ");
        string urSpot = Console.ReadLine();

        //for loop to access indices of each item
        // as iterate through list
        for (int s = 0; s < foodSpots.Count; s++)
        {
            //if statement to check if food spot selected
            // by user is equal to current food spot iterated through in loop
            if (urSpot == foodSpots[s])
            {
                //print indices if there is a match
                Console.WriteLine("Your food spot is at indices: " + s);
            }

            //if statement that checks if user text isnt on list
            //if so, then let them know it isnt on our list
            if (urSpot != foodSpots[s])
            {
                Console.WriteLine("Sorry, that food spot isn\'t on our list.");
            }
        }



        //creating a list with two identical strings included
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Pear",
            "Watermelon",
            "Cherry",
            "Orange",
            "Watermelon"
        };
        List<string> duplicates = new List<string>();

        //foreach loop that evaluates each item in list
        Console.WriteLine("Fruit List...\n");
        Console.WriteLine("Looking for fruit in the list...\n");
        //if statement to check if fruit already exists in list
        //using Contains to check the items contained in the list
        foreach (string fruit in fruits)
        {
            if (duplicates.Contains(fruit))
            {
                Console.WriteLine("The fruit "+ fruit +" has repeated!");
            }
            else
            {
                Console.WriteLine("This fruit " + fruit + " has not repeated.");
            }
            duplicates.Add(fruit);

        }

        Console.ReadLine();
    }
}
