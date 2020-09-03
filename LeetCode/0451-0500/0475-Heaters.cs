//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/359572928/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0475_Heaters
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);

            var distances = new int[houses.Length];
            for (int i = 0; i < houses.Length; i++)
                distances[i] = int.MaxValue;

            for (int i = 0, h = 0; i < houses.Length && h < heaters.Length;)
            {
                if (houses[i] <= heaters[h])
                {
                    distances[i] = heaters[h] - houses[i];
                    i++;
                }
                else
                    h++;
            }

            for (int i = houses.Length - 1, h = heaters.Length - 1; i >= 0 && h >= 0;)
            {
                if (houses[i] >= heaters[h])
                {
                    distances[i] = Math.Min(distances[i], houses[i] - heaters[h]);
                    i--;
                }
                else
                    h--;
            }

            return distances.Max();
        }
    }
}
