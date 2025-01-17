using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_2
{
    internal class DiceClass
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
}
