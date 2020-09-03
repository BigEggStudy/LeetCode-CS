//-----------------------------------------------------------------------------
// Runtime: 140ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0947_MostStonesRemovedWithSameRoworColumn
    {
        private const int BOARD_SIZE = 10000;

        public int RemoveStones(int[][] stones)
        {
            var uf = new UnionFind(BOARD_SIZE * 2);

            foreach (var stone in stones)
                uf.Union(stone[0], stone[1] + BOARD_SIZE);

            var set = new HashSet<int>();
            foreach (var stone in stones)
                set.Add(uf.FindParent(stone[0]));
            return stones.Length - set.Count;
        }

        public class UnionFind
        {
            private int[] parents;

            public UnionFind(int size)
            {
                parents = new int[size];
                for (int i = 0; i < size; i++)
                    parents[i] = i;
            }

            public int FindParent(int x)
            {
                while (parents[x] != x)
                    x = parents[x];
                return parents[x];
            }

            public void Union(int x, int y)
            {
                parents[FindParent(x)] = FindParent(y);
            }
        }
    }
}
