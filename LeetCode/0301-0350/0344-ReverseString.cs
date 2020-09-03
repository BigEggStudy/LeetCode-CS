//-----------------------------------------------------------------------------
// Runtime: 388ms
// Memory Usage: 33.5 MB
// Link: https://leetcode.com/submissions/detail/262779243/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0344_ReverseString
    {
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0) return;

            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++; j--;
            }
        }
    }
}
