//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.9 MB
// Link: https://leetcode.com/submissions/detail/356457712/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _060_PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            var nums = new List<int>();
            var group = 1;
            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
                group *= i;
            }

            if (k > group) return "";
            k = k > 0 ? k - 1 : 0;

            var result = new StringBuilder();
            var index = -1;
            while (n > 0)
            {
                group /= n;
                index = k / group;
                result.Append(nums[index]);
                nums.RemoveAt(index);

                k = k % group;
                n--;
            }

            return result.ToString();
        }
    }
}
