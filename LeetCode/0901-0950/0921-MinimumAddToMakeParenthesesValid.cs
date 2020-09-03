//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22 MB
// Link: https://leetcode.com/submissions/detail/360786682/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0921_MinimumAddToMakeParenthesesValid
    {
        public int MinAddToMakeValid(string S)
        {
            var count = 0;
            var result = 0;

            foreach (var ch in S)
            {
                if (ch == '(')
                    count++;
                else
                {
                    if (count == 0) result++;
                    else count--;
                }
            }

            return result + count;
        }
    }
}
