using System;
using mission_2;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        if (!int.TryParse(Console.ReadLine(), out int totalRolls) || totalRolls <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        DiceClass roller = new DiceClass();
        int[] rollResults = roller.SimulateRolls(totalRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 0; i < rollResults.Length; i++)
        {
            int percentage = (rollResults[i] * 100) / totalRolls;
            System.Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

