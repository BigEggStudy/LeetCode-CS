//-----------------------------------------------------------------------------
// Runtime: 368ms
// Memory Usage: 53 MB
// Link: https://leetcode.com/submissions/detail/369365993/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero
    {
        public int MinReorder(int n, int[][] connections)
        {
            var graph = new Dictionary<int, List<(int end, bool incoming)>>();
            foreach (var edge in connections)
            {
                if (!graph.ContainsKey(edge[0])) graph[edge[0]] = new List<(int, bool)>();
                if (!graph.ContainsKey(edge[1])) graph[edge[1]] = new List<(int, bool)>();

                graph[edge[0]].Add((edge[1], false));
                graph[edge[1]].Add((edge[0], true));
            }

            var visited = new bool[n];
            visited[0] = true;
            var queue = new Queue<int>();
            queue.Enqueue(0);

            var count = 0;
            while (queue.Count > 0)
            {
                var start = queue.Dequeue();
                foreach ((int end, bool incoming) in graph[start])
                {
                    if (visited[end]) continue;
                    if (!incoming) count++;
                    queue.Enqueue(end);
                    visited[end] = true;
                }
            }

            return count;
        }
    }
}
