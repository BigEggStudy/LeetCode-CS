//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0421_MaximumXOROfTwoNumbersInAnArray
    {
        public int FindMaximumXOR(int[] nums)
        {
            var set = new HashSet<int>(nums.Length);
            int ret = 0, mask = 0;
            for (int i = 31; i >= 0; --i)
            {
                mask |= 1 << i;
                foreach (int num in nums)
                    set.Add(num & mask);

                int find = ret | (1 << i);
                foreach (int num in set)
                {
                    if (set.Contains(num ^ find))
                    {
                        ret = find;
                        break;
                    }
                }
                set.Clear();
            }
            return ret;
        }
    }
}
