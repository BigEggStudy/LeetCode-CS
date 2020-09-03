//-----------------------------------------------------------------------------
// Runtime: 296ms
// Memory Usage: 44.5 MB
// Link: https://leetcode.com/submissions/detail/345739430/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0886_PossibleBipartition
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            var colors = new Dictionary<int, int>();
            var graph = new List<IList<int>>(N + 1);
            for (int i = 0; i <= N; i++)
                graph.Add(new List<int>());
            foreach (var dislike in dislikes)
            {
                graph[dislike[0]].Add(dislike[1]);
                graph[dislike[1]].Add(dislike[0]);
            }

            for (int i = 1; i <= N; i++)
                if (!colors.ContainsKey(i))
                    if (!DFS(i, 0, graph, colors))
                        return false;

            return true;
        }

        private bool DFS(int i, int color, List<IList<int>> graph, Dictionary<int, int> colors)
        {
            if (colors.ContainsKey(i))
                return colors[i] == color;

            colors.Add(i, color);
            foreach (var j in graph[i])
                if (!DFS(j, color ^ 1, graph, colors))
                    return false;

            return true;
        }
    }
}
