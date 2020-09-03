//-----------------------------------------------------------------------------
// Runtime: 128ms
// Memory Usage: 26.8 MB
// Link: https://leetcode.com/submissions/detail/373272417/
//-----------------------------------------------------------------------------

using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0179_LargestNumber
    {
        public string LargestNumber(int[] nums)
        {
            if (nums.Length == 0) return string.Empty;
            if (nums.Length == 1) return nums[0].ToString();

            var numsStr = nums.Select(num => num.ToString()).ToArray();
            Array.Sort(numsStr, (a, b) => (b + a).CompareTo(a + b));

            if (numsStr[0] == "0") return "0";

            var sb = new StringBuilder();
            foreach (var str in numsStr)
                sb.Append(str);

            return sb.ToString();
        }
    }
}
