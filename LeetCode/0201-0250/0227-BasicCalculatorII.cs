//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/365839655/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0227_BasicCalculatorII
    {
        public int Calculate(string s)
        {
            char sign = '+';
            var nums = new Stack<int>();
            int cur = 0;

            for (int i = 0; i <= s.Length; i++)
            {
                if (i < s.Length && s[i] >= '0' && s[i] <= '9')
                    cur = cur * 10 + s[i] - '0';
                else if (i == s.Length || s[i] != ' ')
                {
                    if (sign == '+') nums.Push(cur);
                    else if (sign == '-') nums.Push(-cur);
                    else if (sign == '*')
                    {
                        var pre = nums.Pop();
                        nums.Push(pre * cur);
                    }
                    else if (sign == '/')
                    {
                        var pre = nums.Pop();
                        nums.Push(pre / cur);
                    }

                    if (i < s.Length)
                    {
                        cur = 0;
                        sign = s[i];
                    }
                }
            }

            var res = 0;
            while (nums.Count > 0)
                res += nums.Pop();
            return res;
        }
    }
}
