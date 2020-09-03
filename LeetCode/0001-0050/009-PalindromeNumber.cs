//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 15.9 MB
// Link: https://leetcode.com/submissions/detail/351897898/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) { return false; }
            if (x < 10) { return true; }

            var temp = x;
            var y = 0;
            var digit = 0;
            while (temp != 0)
            {
                digit = temp % 10;
                y = y * 10 + digit;
                temp /= 10;
            }

            return x == y;
        }
    }
}
