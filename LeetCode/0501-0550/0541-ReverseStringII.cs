//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/351890985/
//-----------------------------------------------------------------------------

using System;
using System.Text;

namespace LeetCode
{
    public class _0541_ReverseStringII
    {
        public string ReverseStr(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) return s;

            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                int start = i, end = Math.Min(i + k, s.Length) - 1;
                while (start < end)
                {
                    var temp = s[start];
                    sb[start++] = sb[end];
                    sb[end--] = temp;
                }
            }

            return sb.ToString();
        }
    }
}
