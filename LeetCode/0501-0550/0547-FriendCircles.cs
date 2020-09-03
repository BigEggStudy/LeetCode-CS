//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 28.3 MB
// Link: https://leetcode.com/submissions/detail/375119712/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0547_FriendCircles
    {
        public int FindCircleNum(int[][] M)
        {
            var N = M.Length;
            var uf = new UnionFind(N);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < i; j++)
                    if (M[i][j] == 1)
                        uf.Union(i, j);

            return uf.Count;
        }

        public class UnionFind
        {
            private int[] parents;

            public UnionFind(int N)
            {
                parents = new int[N];
                for (int i = 0; i < N; i++)
                    parents[i] = i;
                Count = N;
            }

            public int Count { get; set; }

            public int Find(int i)
            {
                if (parents[i] != i)
                    parents[i] = Find(parents[i]);

                return parents[i];
            }

            public void Union(int i, int j)
            {
                var index1 = Find(i);
                var index2 = Find(j);

                if (index1 == index2) return;

                parents[index1] = index2;
                Count--;
            }
        }
    }
}
