//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0329_LongestIncreasingPathInAMatrix
    {
        private readonly static int[][] dirs = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };

        public int LongestIncreasingPath(int[][] matrix)
        {
            if (matrix.Length == 0) return 0;
            int M = matrix.Length, N = matrix[0].Length;
            var cache = new int[M, N];

            var maxValue = 0;
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    maxValue = Math.Max(maxValue, DFS(cache, matrix, M, N, i, j));
            return maxValue + 1;
        }

        private int DFS(int[,] cache, int[][] matrix, int M, int N, int i, int j)
        {
            if (cache[i, j] != 0) return cache[i, j];
            foreach (var dir in dirs)
            {
                int x = i + dir[0], y = j + dir[1];
                if (0 <= x && x < M && 0 <= y && y < N)
                    if (matrix[x][y] > matrix[i][j])
                        cache[i, j] = Math.Max(cache[i, j], DFS(cache, matrix, M, N, x, y) + 1);
            }
            return cache[i, j];
        }
    }
}
