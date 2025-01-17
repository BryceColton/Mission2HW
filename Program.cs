
internal class Program
{
    private static void Main(string[] args)
    {

        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.Write("How many dice rolls would you like to simulate? ");
        if (!int.TryParse(Console.ReadLine(), out int totalRolls) || totalRolls <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        RollemDice roller = new RollemDice();
        int[] rollResults = roller.SimulateRolls(totalRolls);

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 0; i < rollResults.Length; i++)
        {
            int percentage = (rollResults[i] * 100) / totalRolls;
            System.Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

class RollemDice
{
    public int[] SimulateRolls(int totalRolls)
    {
        int[] rollCounts = new int[11];
        Random rnd = new Random();

        for (int i = 0; i < totalRolls; i++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;

            rollCounts[sum - 2]++;
        }

        return rollCounts;
    }


}