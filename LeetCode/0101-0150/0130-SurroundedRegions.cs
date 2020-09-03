//-----------------------------------------------------------------------------
// Runtime: 332ms
// Memory Usage: 33.8 MB
// Link: https://leetcode.com/submissions/detail/275843408/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0130_SurroundedRegions
    {
        public void Solve(char[][] board)
        {
            int m = board.Length;
            if (m < 3) return;
            int n = board[0].Length;
            if (n < 3) return;

            var uf = new UnionFind(m * n + 1);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (board[i][j] == 'O')
                        if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                            uf.Union(i * n + j, m * n);
                        else
                        {
                            if (board[i - 1][j] == 'O')
                                uf.Union(i * n + j, (i - 1) * n + j);
                            if (board[i + 1][j] == 'O')
                                uf.Union(i * n + j, (i + 1) * n + j);
                            if (board[i][j - 1] == 'O')
                                uf.Union(i * n + j, i * n + j - 1);
                            if (board[i][j + 1] == 'O')
                                uf.Union(i * n + j, i * n + j + 1);
                        }

            int pIndex = uf.Find(m * n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (uf.Find(i * n + j) != pIndex)
                        board[i][j] = 'X';
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
