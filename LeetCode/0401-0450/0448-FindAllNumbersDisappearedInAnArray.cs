//-----------------------------------------------------------------------------
// Runtime: 296ms
// Memory Usage: 43.5 MB
// Link: https://leetcode.com/submissions/detail/341003625/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0448_FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                    nums[index] *= -1;
            }

            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    result.Add(i + 1);

            return result;
        }
    }
}
