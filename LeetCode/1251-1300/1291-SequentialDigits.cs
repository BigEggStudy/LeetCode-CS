//-----------------------------------------------------------------------------
// Runtime: 204ms
// Memory Usage: 25.3 MB
// Link: https://leetcode.com/submissions/detail/399385446/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1291_SequentialDigits
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var sample = "123456789";
            int n = 10;
            var results = new List<int>();

            int lowLen = low.ToString().Length;
            int highLen = high.ToString().Length;
            for (int length = lowLen; length < highLen + 1; length++)
                for (int start = 0; start < n - length; start++)
                {
                    int num = int.Parse(sample.Substring(start, length));
                    if (num >= low && num <= high)
                        results.Add(num);
                }
            return results;
        }
    }
}
