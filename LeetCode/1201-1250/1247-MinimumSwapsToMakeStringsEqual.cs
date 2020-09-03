//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.1 MB
// Link: https://leetcode.com/submissions/detail/371237555/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1247_MinimumSwapsToMakeStringsEqual
    {
        public int MinimumSwap(string s1, string s2)
        {
            if (s1.Length != s2.Length) return -1;

            int xy = 0;
            int yx = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'x' && s2[i] == 'y')
                    xy++;
                else if (s1[i] == 'y' && s2[i] == 'x')
                    yx++;
            }

            if ((xy + yx) % 2 == 1) return -1;
            return xy / 2 + yx / 2 + xy % 2 + yx % 2;
        }
    }
}
