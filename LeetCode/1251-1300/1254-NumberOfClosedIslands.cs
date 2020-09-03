//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 27.2 MB
// Link: https://leetcode.com/submissions/detail/371226417/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1254_NumberOfClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            var N = grid.Length;
            var M = grid[0].Length;

            var uf = new UnionFind(grid);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (grid[i][j] == 0)
                    {
                        if (i == 0 || j == 0 || i == N - 1 || j == M - 1)
                            uf.Union(i * M + j, N * M);

                        if (i - 1 >= 0 && grid[i - 1][j] == 0)
                            uf.Union(i * M + j, (i - 1) * M + j);
                        if (i + 1 < N && grid[i + 1][j] == 0)
                            uf.Union(i * M + j, (i + 1) * M + j);
                        if (j - 1 >= 0 && grid[i][j - 1] == 0)
                            uf.Union(i * M + j, i * M + j - 1);
                        if (j + 1 < M && grid[i][j + 1] == 0)
                            uf.Union(i * M + j, i * M + j + 1);
                    }
            return uf.Count() - 1;
        }

        public class UnionFind
        {
            private int count = 0;
            private int[] parents;
            private int[] ranks;

            public UnionFind(int[][] grid)
            {
                count = 0;
                int N = grid.Length;
                int M = grid[0].Length;

                parents = new int[N * M + 1];
                ranks = new int[N * M + 1];
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < M; j++)
                    {
                        if (grid[i][j] == 0)
                        {
                            parents[i * M + j] = i * M + j;
                            count++;
                        }
                    }

                parents[N * M] = N * M;
                count++;
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

                if (pIndex1 != pIndex2)
                {
                    if (ranks[pIndex1] >= ranks[pIndex2])
                    {
                        parents[pIndex2] = pIndex1;
                        ranks[pIndex1]++;
                    }
                    else
                    {
                        parents[pIndex1] = pIndex2;
                        ranks[pIndex2]++;
                    }
                    count--;
                }
            }

            public int Count()
            {
                return count;
            }
        }
    }
}
