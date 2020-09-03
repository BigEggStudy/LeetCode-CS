//-----------------------------------------------------------------------------
// Runtime: 992ms
// Memory Usage: 83.4 MB
// Link: https://leetcode.com/submissions/detail/365305888/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1192_CriticalConnectionsInANetwork
    {
        public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            var graph = new Dictionary<int, IList<int>>();
            var edges = new HashSet<(int, int)>();
            foreach (var connection in connections)
            {
                if (!graph.ContainsKey(connection[0]))
                    graph[connection[0]] = new List<int>();
                if (!graph.ContainsKey(connection[1]))
                    graph[connection[1]] = new List<int>();

                graph[connection[0]].Add(connection[1]);
                graph[connection[1]].Add(connection[0]);

                edges.Add((connection[0], connection[1]));
            }

            var ranks = new int[n];
            for (int i = 0; i < n; i++)
                ranks[i] = -2;

            DFS(0, 0, graph, edges, ranks, n);

            return edges.Select(a => new int[2] { a.Item1, a.Item2 }).ToList<IList<int>>();
        }

        private int DFS(int node, int depth, Dictionary<int, IList<int>> graph, HashSet<(int, int)> edges, int[] ranks, int n)
        {
            if (ranks[node] >= 0) return ranks[node];

            ranks[node] = depth;
            var minStartPoint = n;
            foreach (var neighbor in graph[node])
            {
                if (ranks[neighbor] == depth - 1) continue;
                var startPoint = DFS(neighbor, depth + 1, graph, edges, ranks, n);
                if (startPoint <= depth)
                {
                    if (edges.Contains((node, neighbor)))
                        edges.Remove((node, neighbor));
                    else if (edges.Contains((neighbor, node)))
                        edges.Remove((neighbor, node));
                }
                minStartPoint = Math.Min(minStartPoint, startPoint);
            }
            return minStartPoint;
        }
    }
}
