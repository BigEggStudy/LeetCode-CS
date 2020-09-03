//-----------------------------------------------------------------------------
// Runtime: 344ms
// Memory Usage: 43.8 MB
// Link: https://leetcode.com/submissions/detail/383932927/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1102_PathWithMaximumMinimumValue
    {
        public int MaximumMinimumPath(int[][] A)
        {
            int N = A.Length;
            int M = A[0].Length;

            var directions = new List<(int dr, int dc)>() { (1, 0), (-1, 0), (0, 1), (0, -1) };
            var uf = new UnionFind(N * M);
            var visited = new bool[N, M];

            var points = new List<(int r, int c, int val)>(N * M);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    points.Add((i, j, A[i][j]));
            points.Sort((a, b) => b.val.CompareTo(a.val));

            foreach ((int r, int c, int val) in points)
            {
                visited[r, c] = true;
                foreach ((int dr, int dc) in directions)
                {
                    int newR = r + dr, newC = c + dc;
                    if (newR >= 0 && newR < N && newC >= 0 && newC < M && visited[newR, newC])
                        uf.Union(r * M + c, newR * M + newC);
                }
                if (uf.Find(0) == uf.Find(N * M - 1))
                    return A[r][c];
            }

            return -1;
        }

        public class UnionFind
        {
            private int[] parents;
            private int[] ranks;

            public UnionFind(int count)
            {
                parents = new int[count];
                ranks = new int[count];

                for (int i = 0; i < count; i++)
                    parents[i] = i;
            }

            public int Find(int index)
            {
                if (parents[index] != index)
                    parents[index] = Find(parents[index]);

                return parents[index];
            }

            public void Union(int index1, int index2)
            {
                var pIndex1 = Find(index1);
                var pIndex2 = Find(index2);

                if (pIndex1 == pIndex2) return;
                if (ranks[pIndex1] >= ranks[pIndex2])
                {
                    parents[pIndex2] = pIndex1;
                    ranks[pIndex2]++;
                }
                else
                {
                    parents[pIndex1] = pIndex2;
                    ranks[pIndex1]++;
                }
            }
        }
    }
}
