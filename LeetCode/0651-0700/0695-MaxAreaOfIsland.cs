//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0695_MaxAreaOfIsland
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var uf = new UnionFind(grid);

            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (grid[i][j] == 1)
                    {
                        if (i - 1 >= 0 && grid[i - 1][j] == 1)
                            uf.Union(i * n + j, (i - 1) * n + j);
                        if (i + 1 < m && grid[i + 1][j] == 1)
                            uf.Union(i * n + j, (i + 1) * n + j);
                        if (j - 1 >= 0 && grid[i][j - 1] == 1)
                            uf.Union(i * n + j, i * n + j - 1);
                        if (j + 1 < n && grid[i][j + 1] == 1)
                            uf.Union(i * n + j, i * n + j + 1);
                    }
            return uf.RankMax();
        }


        public class UnionFind
        {
            private int count = 0;
            private int rankMax = 0;
            private int[] parents;
            private int[] ranks;

            public UnionFind(int[][] grid)
            {
                count = 0;
                int m = grid.Length;
                int n = grid[0].Length;

                parents = new int[m * n];
                ranks = new int[m * n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            parents[i * n + j] = i * n + j;
                            count++;
                            ranks[i * n + j] = 1;
                            rankMax = 1;
                        }
                    }
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
                        ranks[pIndex1] += ranks[pIndex2];
                        rankMax = Math.Max(ranks[pIndex1], rankMax);
                    }
                    else
                    {
                        parents[pIndex1] = pIndex2;
                        ranks[pIndex2] += ranks[pIndex1];
                        rankMax = Math.Max(ranks[pIndex2], rankMax);
                    }
                    count--;
                }
            }

            public int RankMax()
            {
                return rankMax;
            }

            public int Count()
            {
                return count;
            }
        }
    }
}
