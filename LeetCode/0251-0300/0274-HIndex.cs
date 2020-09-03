//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/357948617/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0274_HIndex
    {
        public int HIndex(int[] citations)
        {
            int n = citations.Length;

            int[] papers = new int[n + 1];
            foreach (int c in citations)
                papers[Math.Min(n, c)]++;

            int k = n;
            for (int s = papers[n]; k > s; s += papers[k])
                k--;
            return k;
        }
    }
}
