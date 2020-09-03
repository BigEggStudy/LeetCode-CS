//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 30.3 MB
// Link: https://leetcode.com/submissions/detail/344814701/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0455_AssignCookies
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var child = 0;
            for (int cookie = 0; cookie < s.Length && child < g.Length; cookie++)
            {
                if (g[child] <= s[cookie])
                    child++;
            }

            return child;
        }
    }
}
