//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.1 MB
// Link: https://leetcode.com/submissions/detail/338636813/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0521_LongestUncommonSubsequenceI
    {
        public int FindLUSlength(string a, string b)
        {
            if (a == b) return -1;
            return Math.Max(a.Length, b.Length);
        }
    }
}
