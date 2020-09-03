//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 21.7 MB
// Link: https://leetcode.com/submissions/detail/351443718/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0392_IsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j]) i++;
                j++;
            }

            return i == s.Length;
        }
    }
}
