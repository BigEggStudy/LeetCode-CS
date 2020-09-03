//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 30.5 MB
// Link: https://leetcode.com/submissions/detail/360414445/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1409_QueriesOnAPermutationWithKey
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            var indexes = new int[m];
            for (int i = 0; i < m; i++)
                indexes[i] = i;

            var result = new List<int>(queries.Length);
            foreach (var query in queries)
            {
                var current = indexes[query - 1];
                result.Add(current);
                for (int j = 0; j < m; j++)
                {
                    if (indexes[j] < current)
                        indexes[j]++;
                }
                indexes[query - 1] = 0;
            }

            return result.ToArray();
        }
    }
}
