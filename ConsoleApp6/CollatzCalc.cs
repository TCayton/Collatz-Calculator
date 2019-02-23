using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            // values to begin from should user wish to continue from largest tested number
            var x = BigInteger.Parse("100304170900795686912");
            var y = BigInteger.Parse("200000000000000000000");
            List<BigInteger> sequence = new List<BigInteger>();
            // option to choose to enter 'own' number or continue
            Console.Write("Would you like to use your own number or continue? (write 'own' or 'continue'): ");
            var choice = Console.ReadLine();
            if (choice == "own")
            {
                // try block to prevent any non-numeric inputs
                try
                {
                    Console.Write("Please enter your own (positive) integer: ");
                    x = BigInteger.Parse(Console.ReadLine());
                    var z = x; // here z is assigned so that x can retain the original inputted value for use later.
                    do
                    {
                        if (z % 2 == 0) // here the maths happens! The number is written to the console each time so that the maths can be observed.
                        {
                            z = z / 2;
                            Console.WriteLine(z);
                            sequence.Add(z);
                        }
                        else
                        {
                            z = z * 3 + 1;
                            Console.WriteLine(z);
                            sequence.Add(z);
                        }
                    } while (z != 1);
                    Console.WriteLine("There are {0} numbers in the Collatz sequence for {1}.", sequence.Count, x);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry please close the program and try that again. Make sure you entered a number.");
                }
            }
            else if (choice == "continue") // block for the choice of continuing
            {
                do
                {
                    var input = x++; // number will iterate each time and keep going until the y variable has been exceeded (to prevent the program from running indefinitely).
                    var number = input;
                    Console.WriteLine("Initial Number: {0}", input);
                    do
                    {
                        if (input % 2 == 0)
                        {
                            input = input / 2;
                            Console.WriteLine(input);
                            sequence.Add(input);
                        }
                        else
                        {
                            input = input * 3 + 1;
                            Console.WriteLine(input);
                            sequence.Add(input);
                        }
                    } while (input != 1);
                    Console.WriteLine("There are {0} numbers in the Collatz sequence for {1}.", sequence.Count, number);
                } while (x < y);
            }
            else // this just allows a user to enter something other than 'own' or 'continue' but gives advice on where they went wrong
                Console.WriteLine("It seems you entered incorrectly, please close the program and try again (make sure to enter only 'own' or 'continue' without the quotation marks).");
        }
    }
}