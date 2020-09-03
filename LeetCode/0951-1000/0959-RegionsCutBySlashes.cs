//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0959_RegionsCutBySlashes
    {
        public int RegionsBySlashes(string[] grid)
        {
            var N = grid.Length;
            var uf = new UnionFind(4 * N * N);
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if (i > 0) uf.Union(ComputeIndex(i, j, 0, N), ComputeIndex(i - 1, j, 2, N));
                    if (j > 0) uf.Union(ComputeIndex(i, j, 3, N), ComputeIndex(i, j - 1, 1, N));
                    if (grid[i][j] != '\\')
                    {
                        uf.Union(ComputeIndex(i, j, 0, N), ComputeIndex(i, j, 3, N));
                        uf.Union(ComputeIndex(i, j, 1, N), ComputeIndex(i, j, 2, N));
                    }
                    if (grid[i][j] != '/')
                    {
                        uf.Union(ComputeIndex(i, j, 0, N), ComputeIndex(i, j, 1, N));
                        uf.Union(ComputeIndex(i, j, 2, N), ComputeIndex(i, j, 3, N));
                    }
                }

            return uf.Count();
        }

        private int ComputeIndex(int row, int column, int index, int N)
        {
            return (row * N + column) * 4 + index;
        }


        public class UnionFind
        {
            private int[] parents;
            private int capacity;
            private int count;

            public UnionFind(int capacity)
            {
                this.capacity = capacity;
                this.count = capacity;
                this.parents = new int[capacity];
                for (int i = 0; i < capacity; i++)
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
                var p1 = Find(index1);
                var p2 = Find(index2);

                if (p1 != p2)
                {
                    parents[p1] = p2;
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
