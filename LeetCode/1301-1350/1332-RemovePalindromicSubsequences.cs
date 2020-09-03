//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.8 MB
// Link: https://leetcode.com/submissions/detail/338611018/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1332_RemovePalindromicSubsequences
    {
        public int RemovePalindromeSub(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int lo = 0, hi = s.Length - 1;
            while (lo < hi)
            {
                if (s[lo] != s[hi]) return 2;
                lo++;
                hi--;
            }

            return 1;
        }
    }
}
