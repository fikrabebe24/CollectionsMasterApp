using System;
using System.Collections.Generic;

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
            int[] fiftyNums = new int[50];
            //NumberPrinter(fiftyNums);

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(fiftyNums);
            NumberPrinter(fiftyNums);

            //TODO: Print the first number of the array
            Console.WriteLine(fiftyNums[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(fiftyNums[49]);
            //or
            Console.WriteLine(fiftyNums.Length - 1);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fiftyNums);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(fiftyNums);
            NumberPrinter(fiftyNums);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(fiftyNums);



            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(fiftyNums);
            NumberPrinter(fiftyNums);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(fiftyNums);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> intList = new List<int>() { };


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity of List");
            Console.WriteLine(intList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(intList);

            //TODO: Print the new capacity
            Console.WriteLine("Capacity of List After Population");
            Console.WriteLine(intList.Capacity);
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userInput = int.Parse(Console.ReadLine());

            NumberChecker(intList, userInput);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newAdrray = intList.ToArray();

            //TODO: Clear the list
            intList.Clear();
      

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count-1; i >= 0; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }

                NumberPrinter(numberList);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool numberFound = false;

            foreach(var number in numberList)
            {
                if(number == searchNumber)
                {
                    Console.WriteLine("Found Number");
                    numberFound = true;
                    break;
                }
               
            }

            if(numberFound = false)
            {
                Console.WriteLine("Did not find Number");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int j=0; j<=51; j++)
            {
                int randomNumber2 = rng.Next(0, 51);
                numberList.Add(randomNumber2);
            }

            NumberPrinter(numberList);
    

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber = rng.Next(0, 51);
                numbers[i] = randomNumber;

                Console.WriteLine();
            }


        }

        private static void ReverseArray(int[] array)
        {
            int[] custReverseArray = new int[50];
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                custReverseArray[index] = array[i];
                index++;
            }

            NumberPrinter(custReverseArray);
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
