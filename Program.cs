﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            while (true)
            {
                try
                {
                    //Prompt for length and width
                    Console.WriteLine("Please enter room length:");
                    double length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter room width:");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter room height:");
                    double height = double.Parse(Console.ReadLine());

                    //Calculate Area and Perimeter
                    Console.WriteLine("Area: " + (length * width));
                    Console.WriteLine("Perimeter: " + ((2 * length) + (2 * width)));
                    Console.WriteLine("Volume: " + (length * width * height));
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not an accepted input");
                }
                //Prompt user to continue
                Console.WriteLine("Would you like to continue? (y/n)");
                string userContinue = Console.ReadLine().ToLower();

                if (userContinue == "y")
                {
                    continue;
                }
                else if (userContinue == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid response. Please try again: (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                }
            }
        }
    }
}

