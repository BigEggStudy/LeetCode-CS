//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 46 MB
// Link: https://leetcode.com/submissions/detail/368357900/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0210_CourseSchedule
    {
        public int[] CanFinish(int numCourses, int[][] prerequisites)
        {
            var adj = new bool[numCourses, numCourses];
            BuildGraph(adj, prerequisites);

            var visited = new int[numCourses];
            var result = new List<int>();
            for (int i = 0; i < numCourses; i++)
                if (visited[i] == 0 && !DFS(adj, visited, i, numCourses, result)) return new int[] { };

            result.Reverse();
            return result.ToArray();
        }

        private bool DFS(bool[,] adj, int[] visited, int i, int numCourses, IList<int> result)
        {
            visited[i] = 1;
            for (int j = 0; j < numCourses; j++)
            {
                if (adj[i, j])
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                        if (!DFS(adj, visited, j, numCourses, result)) return false;
                }
            }

            visited[i] = 2;
            result.Add(i);
            return true;
        }

        private void BuildGraph(bool[,] adj, int[][] prerequisites)
        {
            foreach (var prerequisite in prerequisites)
                adj[prerequisite[1], prerequisite[0]] = true;
        }
    }
}
