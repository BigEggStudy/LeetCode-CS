//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/326842297/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1221_SplitAStringInBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            var count = 0;
            var result = 0;
            foreach (var ch in s)
            {
                count += ch == 'L' ? 1 : -1;
                if (count == 0)
                    result++;
            }

            return result;
        }
    }
}
