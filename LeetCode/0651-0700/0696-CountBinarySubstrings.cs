//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/342505467/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0696_CountBinarySubstrings
    {
        public int CountBinarySubstrings(string s)
        {
            int curr = 1, prev = 0, result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {
                    result += Math.Min(curr, prev);
                    prev = curr;
                    curr = 1;
                }
                else
                    curr++;
            }

            return result + Math.Min(curr, prev);
        }
    }
}
