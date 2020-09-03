//-----------------------------------------------------------------------------
// Runtime: 140ms
// Memory Usage: 27.6 MB
// Link: https://leetcode.com/submissions/detail/375114984/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0317_ShortestDistanceFromAllBuildings
    {
        public int ShortestDistance(int[][] grid)
        {
            if (grid == null || grid[0].Length == 0) return 0;

            var directions = new int[4][] { new int[2] { 1, 0 }, new int[2] { 0, 1 }, new int[2] { -1, 0 }, new int[2] { 0, -1 }, };

            int N = grid.Length, M = grid[0].Length;
            var distances = new int[N, M];
            var reach = new int[N, M];
            int buildingNum = 0;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (grid[i][j] == 1)
                    {
                        buildingNum++;
                        var queue = new Queue<(int r, int c)>();
                        queue.Enqueue((i, j));

                        var isVisited = new bool[N, M];
                        int distance = 1;

                        while (queue.Count > 0)
                        {
                            int size = queue.Count;
                            for (int q = 0; q < size; q++)
                            {
                                (int r, int c) = queue.Dequeue();
                                foreach (var dir in directions)
                                {
                                    int nextRow = r + dir[0];
                                    int nextCol = c + dir[1];

                                    if (nextRow >= 0 && nextRow < N && nextCol >= 0 && nextCol < M &&
                                        grid[nextRow][nextCol] == 0 && !isVisited[nextRow, nextCol])
                                    {
                                        distances[nextRow, nextCol] += distance;
                                        reach[nextRow, nextCol]++;
                                        isVisited[nextRow, nextCol] = true;
                                        queue.Enqueue((nextRow, nextCol));
                                    }
                                }
                            }
                            distance++;
                        }
                    }

            var min = int.MaxValue;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (grid[i][j] == 0 && reach[i, j] == buildingNum)
                        min = Math.Min(min, distances[i, j]);

            return min == int.MaxValue ? -1 : min;
        }
    }
}
