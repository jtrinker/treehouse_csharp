using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // this is a method
        // the word before the name of the method is called the 'return type', meaning the method will return that type to the method's caller.
        // here the return type is of type 'void' because nothing is being returned.

        // the 'Main' method is the first method in the program that will be run.
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string minutesEntered = Console.ReadLine();

                if (minutesEntered == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(minutesEntered);

                    if (minutes <= 0)
                    {
                        Console.WriteLine("Try again.");

                        // the 'continue' keyword starts the while loop over at the beginning -- starts a new iteration
                        continue;
                    }

                    if (minutes <= 10)
                    {
                        Console.WriteLine("OK work.");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Pretty good work.");
                    }
                    else if (minutes > 30)
                    {
                        Console.WriteLine("Nice.");
                    }

                    // Add minutes exercised to running total
                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");
                    Console.ReadLine();
                }

            }
            Console.WriteLine("Goodbye.");

        }
    }
}
