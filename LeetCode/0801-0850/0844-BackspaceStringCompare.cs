//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 22.3 MB
// Link: https://leetcode.com/submissions/detail/322438313/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0844_BackspaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            var i = S.Length - 1;
            var j = T.Length - 1;
            var skipS = 0;
            var skipT = 0;

            while (i >= 0 || j >= 0)
            {
                while (i >= 0)
                {
                    if (S[i] == '#')
                        skipS++;
                    else if (skipS > 0)
                        skipS--;
                    else
                        break;
                    i--;
                }
                while (j >= 0)
                {
                    if (T[j] == '#')
                        skipT++;
                    else if (skipT > 0)
                        skipT--;
                    else
                        break;
                    j--;
                }

                if (i >= 0 && j >= 0 && S[i] != T[j]) return false;
                if ((i >= 0) != (j >= 0)) return false;
                i--; j--;
            }

            return true;
        }
    }
}
