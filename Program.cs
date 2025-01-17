using System;
using mission_2;

internal class Program
{
    private static void Main(string[] args)
    {
        // This line welcomes the user
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // This line asks how many times the user wants to simulate throwing the dice
        Console.Write("How many dice rolls would you like to simulate? ");

//This next line adds exception handling, the out allows function to return more than one output
        if (!int.TryParse(Console.ReadLine(), out int totalRolls) || totalRolls <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

// This line creates a new DiceClass object and gives access to the simulate rolls function
        DiceClass roller = new DiceClass();
        int[] rollResults = roller.SimulateRolls(totalRolls);

// This next line present conclusion of the simulation with the results 
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");


// This for loop prints out the * asterisk for each combination, this new string function seemed the simplest to use and understand.
        for (int i = 0; i < rollResults.Length; i++)
        {
            int percentage = (rollResults[i] * 100) / totalRolls;
            System.Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

