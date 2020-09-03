//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.8 MB
// Link: https://leetcode.com/submissions/detail/339123078/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0788_RotatedDigits
    {
        public int RotatedDigits(int N)
        {
            var num = N.ToString();
            var length = num.Length;

            var memo = new Dictionary<(int length, bool equality_flag, bool involution_flag), int>();
            return DP(0, true, false, num, length, memo);
        }

        public int DP(int k, bool equality_flag, bool involution_flag, string num, int length, IDictionary<(int length, bool equality_flag, bool involution_flag), int> memo)
        {
            if (k == length) return involution_flag ? 1 : 0;
            if (!memo.ContainsKey((k, equality_flag, involution_flag)))
            {
                var current = 0;
                for (char ch = '0'; ch <= (equality_flag ? num[k] : '9'); ch++)
                {
                    if (ch == '3' || ch == '4' || ch == '7') continue;
                    current += DP(k + 1, equality_flag && ch == num[k], involution_flag || (ch == '2' || ch == '5' || ch == '6' || ch == '9'), num, length, memo);
                }

                memo[(k, equality_flag, involution_flag)] = current;
            }

            return memo[(k, equality_flag, involution_flag)];
        }
    }
}
