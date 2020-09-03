//-----------------------------------------------------------------------------
// Runtime: 576ms
// Memory Usage: 50.4 MB
// Link: https://leetcode.com/submissions/detail/375087069/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1235_MaximumProfitInJobScheduling
    {
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var pairs = new (int start, int end, int profit)[profit.Length];
            for (int i = 0; i < profit.Length; i++)
                pairs[i] = (startTime[i], endTime[i], profit[i]);
            Array.Sort(pairs, (a, b) => a.end.CompareTo(b.end));

            var dpEndTime = new List<int>();
            var dpProfit = new List<int>();
            dpEndTime.Add(0);
            dpProfit.Add(0);

            foreach (var pair in pairs)
            {
                var prevIndex = Array.BinarySearch(dpEndTime.ToArray(), pair.start + 1);
                if (prevIndex < -1)
                    prevIndex = ~prevIndex;
                prevIndex--;

                var currentProfit = dpProfit[prevIndex] + pair.profit;
                if (currentProfit > dpProfit[dpProfit.Count - 1])
                {
                    dpProfit.Add(currentProfit);
                    dpEndTime.Add(pair.end); ;
                }
            }

            return dpProfit[dpProfit.Count - 1];
        }
    }
}
