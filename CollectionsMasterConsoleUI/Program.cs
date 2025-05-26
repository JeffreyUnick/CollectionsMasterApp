using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualBasic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var myArray = new int [50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            
            Populater(myArray);
            
            //TODO: Print the first number of the array
            Console.WriteLine($"The first number is {myArray[0]}");

            //TODO: Print the last number of the array   
            Console.WriteLine($"The last number is {myArray[49]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Console.WriteLine("All Numbers Reversed:");
            int[] reversedNumbers = myArray.Reverse().ToArray();
            NumberPrinter(reversedNumbers);
            
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion
            

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(myList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //TODO: Print the new capacity
            Console.WriteLine(myList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(myList, 0);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            OddKiller(myList);
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var convertedList = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                else numbers[i] = numbers[i] ;

                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }
                else Console.WriteLine(numberList[i]); 
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        { 
            string number = Console.ReadLine();
           bool success = int.TryParse(number, out searchNumber);
           if (success && numberList.Contains(searchNumber))
           {
               Console.WriteLine($"Congratulations {searchNumber} is inside the list.");
           }
           else if (success && !numberList.Contains(searchNumber))
           {
               Console.WriteLine($"Sorry {searchNumber} is outside the list.");
           }
           else Console.WriteLine("Invalid input. We need a number bro !!!");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            int i = 0;
            while (i < 51)
            {
                i++;
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 51);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[(array.Length - 1) - i];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
