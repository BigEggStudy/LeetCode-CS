//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 23.6 MB
// Link: https://leetcode.com/submissions/detail/271483819/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0125_ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            s = s.ToLower();

            int head = 0, tail = s.Length - 1;
            while (head <= tail)
            {
                if ((s[head] < 'a' || s[head] > 'z') && (s[head] < '0' || s[head] > '9'))
                    head++;
                else if ((s[tail] < 'a' || s[tail] > 'z') && (s[tail] < '0' || s[tail] > '9'))
                    tail--;
                else if (s[head] != s[tail])
                    return false;
                else
                {
                    head++;
                    tail--;
                }
            }

            return true;
        }
    }
}
