//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 33.4 MB
// Link: https://leetcode.com/submissions/detail/326429951/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1313_DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var results = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
                for (int j = 0; j < nums[i]; j++)
                    results.Add(nums[i + 1]);

            return results.ToArray();
        }
    }
}
