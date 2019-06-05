﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
              //      -- R E S T R I C T I O N S --
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LWords = from words in fruits

                where words.Substring(0, 1) == "L"
                select words;

                // foreach (string L in LWords)
                // {

                //                 Console.WriteLine($"{L}");
                // }

// _________________________________________________________________________________________

                // Which of the following numbers are multiples of 4 or 6
                List<int> numbers = new List<int>()
                    {
                        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                    };

                    IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

                    // foreach (int N in fourSixMultiples) {

                    // Console.WriteLine($"{N}");
                    // }


// ______________________________________________________________________________________________________________


                    // Order these student names alphabetically, in descending order (Z to A)

                    List<string> names = new List<string>()

                        {
                            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                            "Francisco", "Tre"
                        };

                            IEnumerable<string> descend = from name in names
                                          orderby name descending
                                          select name;

                                        //   foreach(string n in descend){

                                        //         Console.WriteLine($"{n}");

                                        //   }

//_______________________________________________________________________________________________________

                        // Build a collection of these numbers sorted in ascending order
                        List<int> aNumbers = new List<int>()
                            {
                                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                            };

                            IEnumerable<int> ascend = from count in aNumbers
                                          orderby count ascending
                                          select count;

                                        //   foreach(int a in ascend){

                                        //         Console.WriteLine($"{a}");

                                        //   }


//_____________________________________________________________________________________________________________

                            // Output how many numbers are in this list
                            List<int> numberOfNumbers = new List<int>()
                                {
                                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                                };

                                Console.WriteLine($"{numberOfNumbers.Count()}");

    //----------------------------------------------------------------------------------------------------

                            // How much money have we made?
                            List<double> purchases = new List<double>()
                                {
                                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                                };

                                Console.WriteLine($"{purchases.Sum()}");

    //----------------------------------------------------------------------------------------------------------

                                    // What is our most expensive product?
                                List<double> prices = new List<double>()
                                {
                                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                                };

                                Console.WriteLine($"{prices.Max()}");

    //-----------------------------------------------------------------------------------------------------------

                                /*
                                    Store each number in the following List until a perfect square
                                    is detected.

                                    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
                                */

                                List<int> wheresSquaredo = new List<int>()
                                {
                                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                                };

                                IEnumerable<int> root = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0);

                                foreach(int sq in root) {
                                    Console.WriteLine(sq);
                                }

    //------------------------------------------------------------------------------------------------------------


        }
    }
}
