//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 28.3 MB
// Link: https://leetcode.com/submissions/detail/384887205/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0490_TheMaze
    {
        public bool HasPath(int[][] maze, int[] start, int[] destination)
        {
            var visited = new bool[maze.Length, maze[0].Length];
            var dirs = new int[4][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
            var queue = new Queue<int[]>();
            queue.Enqueue(start);
            visited[start[0], start[1]] = true;

            while (queue.Count > 0)
            {
                int[] point = queue.Dequeue();
                if (point[0] == destination[0] && point[1] == destination[1])
                    return true;

                foreach (int[] dir in dirs)
                {
                    int x = point[0] + dir[0];
                    int y = point[1] + dir[1];
                    while (x >= 0 && y >= 0 && x < maze.Length && y < maze[0].Length && maze[x][y] == 0)
                    {
                        x += dir[0];
                        y += dir[1];
                    }
                    if (!visited[x - dir[0], y - dir[1]])
                    {
                        queue.Enqueue(new int[] { x - dir[0], y - dir[1] });
                        visited[x - dir[0], y - dir[1]] = true;
                    }
                }
            }
            return false;
        }
    }
}
