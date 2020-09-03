//-----------------------------------------------------------------------------
// Runtime: 268ms
// Memory Usage: 36.2 MB
// Link: https://leetcode.com/submissions/detail/360484268/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0797_AllPathsFromSourceToTarget
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var cache = new Dictionary<int, IList<IList<int>>>();
            return AllPathsSourceTarget(graph, 0, cache);
        }

        private IList<IList<int>> AllPathsSourceTarget(int[][] graph, int node, Dictionary<int, IList<IList<int>>> cache)
        {
            if (cache.ContainsKey(node))
                return cache[node];

            var results = new List<IList<int>>();
            foreach (var next in graph[node])
            {
                if (next == graph.Length - 1)
                    results.Add(new List<int>() { node, next });

                var pathes = AllPathsSourceTarget(graph, next, cache);
                if (pathes.Count > 0)
                {
                    foreach (var path in pathes)
                    {
                        var newPath = new List<int>();
                        newPath.Add(node);
                        newPath.AddRange(path);
                        results.Add(newPath);
                    }
                }
            }

            cache[node] = results;
            return results;
        }
    }
}
