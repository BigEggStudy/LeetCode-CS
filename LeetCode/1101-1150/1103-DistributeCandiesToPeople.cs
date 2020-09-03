//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/336940224/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1103_DistributeCandiesToPeople
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int people = (int)(Math.Sqrt(2 * candies + 0.25) - 0.5);
            int remaining = candies - (people + 1) * people / 2;
            int rows = people / num_people, cols = people % num_people;

            var result = new int[num_people];
            for (int i = 0; i < num_people; i++)
            {
                result[i] = (i + 1) * rows + (rows * (rows - 1) / 2) * num_people;
                if (i < cols)
                    result[i] += i + 1 + rows * num_people;
            }
            result[cols] += remaining;
            return result;
        }
    }
}
