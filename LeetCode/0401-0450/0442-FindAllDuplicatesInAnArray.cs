//-----------------------------------------------------------------------------
// Runtime: 368ms
// Memory Usage: 43.3 MB
// Link: https://leetcode.com/submissions/detail/363998847/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0442_FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num = Math.Abs(nums[i]);
                if (nums[num - 1] < 0)
                    result.Add(num);
                else
                    nums[num - 1] *= -1;
            }

            return result;
        }
    }
}
