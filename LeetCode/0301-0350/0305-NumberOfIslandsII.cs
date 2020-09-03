//-----------------------------------------------------------------------------
// Runtime: 1900ms
// Memory Usage: 51.2 MB
// Link: https://leetcode.com/submissions/detail/382922660/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0305_NumberOfIslandsII
    {
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            var results = new List<int>();
            var parents = new Dictionary<int, int>();
            var count = 0;

            foreach (var pos in positions)
            {
                int r = pos[0], c = pos[1];
                if (parents.ContainsKey(r * n + c))
                {
                    results.Add(count);
                    continue;
                }

                var parentsTemp = new HashSet<int>();
                if (r - 1 >= 0 && parents.ContainsKey((r - 1) * n + c))
                    parentsTemp.Add(parents[(r - 1) * n + c]);
                if (r + 1 < m && parents.ContainsKey((r + 1) * n + c))
                    parentsTemp.Add(parents[(r + 1) * n + c]);
                if (c - 1 >= 0 && parents.ContainsKey(r * n + c - 1))
                    parentsTemp.Add(parents[r * n + c - 1]);
                if (c + 1 < n && parents.ContainsKey(r * n + c + 1))
                    parentsTemp.Add(parents[r * n + c + 1]);

                if (parentsTemp.Count == 0)
                {
                    count++;
                    parents[r * n + c] = r * n + c;
                }
                else
                {
                    var newId = parentsTemp.First();
                    parents[r * n + c] = newId;
                    if (parentsTemp.Count > 1)
                    {
                        var set = new List<int>();
                        foreach (var pair in parents)
                        {
                            if (parentsTemp.Contains(pair.Value))
                                set.Add(pair.Key);
                        }
                        foreach (var key in set)
                            parents[key] = newId;
                        count -= parentsTemp.Count - 1;
                    }
                }

                results.Add(count);
            }

            return results;
        }
    }
}
