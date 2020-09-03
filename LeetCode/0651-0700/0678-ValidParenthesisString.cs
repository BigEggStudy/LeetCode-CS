//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/325968844/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0678_ValidParenthesisString
    {
        public bool CheckValidString(string s)
        {
            var lo = 0;
            var hi = 0;
            foreach (var ch in s)
            {
                lo += ch == '(' ? 1 : -1;
                hi += ch != ')' ? 1 : -1;
                if (hi < 0) return false;
                lo = Math.Max(lo, 0);
            }

            return lo == 0;
        }
    }
}
