//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24 MB
// Link: https://leetcode.com/submissions/detail/334985149/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1217_PlayWithChips
    {
        public int MinCostToMoveChips(int[] chips)
        {
            int odd = 0, even = 0;
            foreach (var chip in chips)
            {
                if (chip % 2 == 0)
                    even++;
                else
                    odd++;
            }

            return Math.Min(odd, even);
        }
    }
}
