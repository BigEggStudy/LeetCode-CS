//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 42.2 MB
// Link: https://leetcode.com/submissions/detail/358742178/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0680_ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                var j = s.Length - 1 - i;
                if (s[i] != s[j])
                    return ValidPalindrome(s, i, j - 1) || ValidPalindrome(s, i + 1, j);
            }

            return true;
        }

        private bool ValidPalindrome(string s, int i, int j)
        {
            for (int k = i; k <= i + (j - i) / 2; k++)
                if (s[k] != s[j - k + i]) return false;

            return true;
        }
    }
}
