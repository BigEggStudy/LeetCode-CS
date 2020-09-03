//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 32.2 MB
// Link: https://leetcode.com/submissions/detail/345121815/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0830_PositionsOfLargeGroups
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            var result = new List<IList<int>>();

            var start = 0;
            for (int i = 1; i < S.Length; i++)
                if (S[i] != S[i - 1])
                {
                    var len = i - start;
                    if (len >= 3)
                        result.Add(new int[] { start, i - 1 });
                    start = i;
                }

            if (S.Length - start > 2)
                result.Add(new int[] { start, S.Length - 1 });

            return result;
        }
    }
}
