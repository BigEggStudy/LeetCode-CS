//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/323881103/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1046_LastStoneWeight
    {
        public int LastStoneWeight(int[] stones)
        {
            var counts = new int[1001];
            var maxWeight = int.MinValue;

            foreach (var stone in stones)
            {
                counts[stone]++;
                maxWeight = Math.Max(maxWeight, stone);
            }

            var biggestWeight = 0;
            var currentWeight = maxWeight;
            while (currentWeight > 0)
            {
                if (counts[currentWeight] == 0)
                {
                    currentWeight--;
                    continue;
                }
                if (biggestWeight == 0)
                {
                    counts[currentWeight] %= 2;
                    if (counts[currentWeight] == 1)
                    {
                        biggestWeight = currentWeight;
                        counts[currentWeight] = 0;
                    }
                    currentWeight--;
                }
                else
                {
                    counts[currentWeight]--;
                    if (biggestWeight - currentWeight <= currentWeight)
                    {
                        counts[biggestWeight - currentWeight]++;
                        biggestWeight = 0;
                    }
                    else
                    {
                        biggestWeight -= currentWeight;
                    }
                }
            }
            return biggestWeight;
        }
    }
}
