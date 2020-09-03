//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/333019392/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1030_MatrixCellsInDistanceOrder
    {
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            (int, int)[] directions = { (0, 1), (0, -1), (1, 0), (-1, 0) };
            var bfs = new Queue<(int, int)>();
            var visited = new bool[R, C];

            var result = new int[R * C][];
            int index = 0;

            bfs.Enqueue((r0, c0));
            visited[r0, c0] = true;
            while (bfs.Count > 0)
            {
                var node = bfs.Dequeue();
                result[index++] = new int[2] { node.Item1, node.Item2 };

                foreach (var direction in directions)
                {
                    int newRow = node.Item1 + direction.Item1;
                    int newCol = node.Item2 + direction.Item2;

                    if (newRow >= 0 && newRow < R && newCol >= 0 && newCol < C && !visited[newRow, newCol])
                    {
                        bfs.Enqueue((newRow, newCol));
                        visited[newRow, newCol] = true;
                    }
                }
            }

            return result;
        }
    }
}
