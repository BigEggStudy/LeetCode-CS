//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/379037663/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0200_NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;

            var uf = new UnionFind(grid);
            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (grid[i][j] == '1')
                    {
                        if (i - 1 >= 0 && grid[i - 1][j] == '1')
                            uf.Union(i * n + j, (i - 1) * n + j);
                        if (i + 1 < m && grid[i + 1][j] == '1')
                            uf.Union(i * n + j, (i + 1) * n + j);
                        if (j - 1 >= 0 && grid[i][j - 1] == '1')
                            uf.Union(i * n + j, i * n + j - 1);
                        if (j + 1 < n && grid[i][j + 1] == '1')
                            uf.Union(i * n + j, i * n + j + 1);
                    }
            return uf.Count();
        }

        public class UnionFind
        {
            private int count = 0;
            private int[] parents;
            private int[] ranks;

            public UnionFind(char[][] grid)
            {
                count = 0;
                int m = grid.Length;
                int n = grid[0].Length;

                parents = new int[m * n];
                ranks = new int[m * n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (grid[i][j] == '1')
                        {
                            parents[i * n + j] = i * n + j;
                            count++;
                        }
                        ranks[i * n + j] = 0;
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
