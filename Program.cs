
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");

        string howMany = "";
        Random rnd = new Random();
        System.Console.WriteLine("How many time do you want to roll the dice?");
        howMany = System.Console.ReadLine();
     
        List<int> diceNumStorage = new List<int>();



        //Basic Syntax for a for loop below

        for (int i = 0; i < int.Parse(howMany); i++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;
            diceNumStorage.Add(sum);

           
        }

        for (int i = 0; i < diceNumStorage.Count; i++)
        {
            Console.WriteLine(diceNumStorage[i]);
        }

    }
}