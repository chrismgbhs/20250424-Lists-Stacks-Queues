using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250424_Lists_Stacks_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doLoop = true;
            bool inputMaxValue = true;
            string input;
            int x;
            int maxValue = 0;
            Random random = new Random();   
            List<int> unsortedList = new List<int>();
            List<int> sortedList = new List<int>();

            // INPUT FOR THE MAXIMUM NUMBER THAT CAN BE GENERATED
            while (inputMaxValue)
            {
                Console.WriteLine("Please type the maximum value of number that can be generated.");
                if (int.TryParse(Console.ReadLine(), out maxValue))
                {
                    inputMaxValue = false;
                }
            }

            Console.WriteLine();

            // THIS LOOP WILL RUN UNTIL DOLOOP BECAME FALSE; THIS IS TRUE AT THE START
            while (doLoop)
            {
                // GIVES THE USER AN OPTION TO CONTINUE GENERATING NUMBER OR EXIT THE PROGRAM EVERYTIME THE LOOP RUNS
                Console.WriteLine("Input any key to generate number or press 'x' to exit the program.");
                input = Console.ReadLine().ToLower();
                if (input == "x")
                {
                    doLoop = false;
                }

                // MAIN BLOCK OF CODE FOR GENERATION OF NUMBERS, ASSIGNING, PRINTING, AND SORTING OF NUMBERS
                else
                {
                    Console.WriteLine("********************************************");

                    // ADDS THE GENERATED NUMBER TO THE UNSORTED LIST
                    x = random.Next(1, maxValue + 1);
                    unsortedList.Add(x);

                    // PRINTING OF UNSORTED LIST OF NUMBERS
                    Console.WriteLine("UNSORTED LIST");
                    foreach (int values in unsortedList)
                    {
                        Console.Write($"{values}, ");
                    }

                    Console.WriteLine();

                    // THIS CREATES A NEW SORTED LIST BEFORE SORTING NUMBERS FROM THE UNSORTED LIST
                    sortedList = new List<int>();

                    // MAIN LOGIC FOR SORTING
                    // THE LOOP RUNS OVER AND OVER AGAIN UNTIL THE NUMBER OF MAXIMUM VALUE FROM THE INPUT EARLIER HAS BEEN MET BY THE COUNTER; THE COUNTER INCREMENTS EVERYTIME THE LOOP ENDS
                    for (int maxValueCounter = 0; maxValueCounter <= maxValue; maxValueCounter++)
                    {
                        // ITERATES THROUGH EACH OF THE VALUES IN THE UNSORTED LIST
                        foreach (int unsortedListValue in unsortedList)
                        {
                            // IF THE VALUE IN THE UNSORTED LIST MATCHES WITH THE COUNTER IN THE FOR LOOP, IT ADDS THE VALUE TO THE SORTED LIST
                            if (maxValueCounter == unsortedListValue)
                            {
                                sortedList.Add(unsortedListValue);
                            } 
                        }   
                    }

                    Console.WriteLine();

                    // PRINTING OF SORTED NUMBERS
                    Console.WriteLine("SORTED LIST");
                    foreach (int values in sortedList)
                    {
                        Console.Write($"{values}, ");
                    }

                    Console.WriteLine();
                    
                }
            }
        }
    }
}
