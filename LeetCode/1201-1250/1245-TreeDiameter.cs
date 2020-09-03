//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/371242921/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1245_TreeDiameter
    {
        private int maxLength = 0;

        public int TreeDiameter(int[][] edges)
        {
            var graph = new Dictionary<int, List<int>>();
            int N = edges.Length;
            for (int i = 0; i <= N; i++)
                graph[i] = new List<int>();

            foreach (var e in edges)
            {
                graph[e[0]].Add(e[1]);
                graph[e[1]].Add(e[0]);
            }

            DFS(0, graph, new bool[N + 1]);
            return maxLength;
        }

        private int DFS(int index, Dictionary<int, List<int>> graph, bool[] visited)
        {
            if (visited[index]) return 0;
            visited[index] = true;

            int first = 0, second = 0;
            foreach (var neighbor in graph[index])
            {
                int length = DFS(neighbor, graph, visited);
                if (length > first)
                {
                    second = first;
                    first = length;
                }
                else if (length > second)
                    second = length;
            }

            maxLength = Math.Max(maxLength, first + second);
            return Math.Max(first, second) + 1;
        }
    }
}
