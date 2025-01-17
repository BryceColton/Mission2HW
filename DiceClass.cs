using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_2
{
    internal class DiceClass
    {
// In this constructor it passes the totalsRolls variable in and assigns the roll counts to an array with 11 spots
        public int[] SimulateRolls(int totalRolls)
            {
                int[] rollCounts = new int[11];
                Random rnd = new Random();

            // This for loop is the simulation logic where it randomly assigns a number between 1 and 6. I have 7 so it goes up to 7.
                for (int i = 0; i < totalRolls; i++)
                {
                    int dice1 = rnd.Next(1, 7);
                    int dice2 = rnd.Next(1, 7);
                    int sum = dice1 + dice2;

                // Roll counts sum - 2 shows that the index is going from [0 to 10] so it has to minus two to keep up with 2 - 12 combinations
                    rollCounts[sum - 2]++;
                }

                return rollCounts;
            }


    }
}
