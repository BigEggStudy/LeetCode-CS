//-----------------------------------------------------------------------------
// Runtime: 160ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _044_WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            int sIndex = 0, pIndex = 0;
            int lastSIndex = -1, lastPIndex = -1;
            while (sIndex < s.Length)
            {
                if (pIndex < p.Length && (p[pIndex] == '?' || p[pIndex] == s[sIndex]))
                {
                    sIndex++;
                    pIndex++;
                }
                else if (pIndex < p.Length && p[pIndex] == '*')
                {
                    pIndex++;
                    if (pIndex == p.Length) { return true; }
                    lastSIndex = sIndex;
                    lastPIndex = pIndex;
                }
                else
                {
                    if (lastSIndex == -1) { return false; }
                    sIndex = ++lastSIndex;
                    pIndex = lastPIndex;
                }
            }

            while (pIndex < p.Length && p[pIndex] == '*') { pIndex++; }
            return pIndex == p.Length && sIndex == s.Length;
        }
    }
}
