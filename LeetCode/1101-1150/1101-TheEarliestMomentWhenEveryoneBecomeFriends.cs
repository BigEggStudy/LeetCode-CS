//-----------------------------------------------------------------------------
// Runtime: 144ms
// Memory Usage: 29.3 MB
// Link: https://leetcode.com/submissions/detail/363981633/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1101_TheEarliestMomentWhenEveryoneBecomeFriends
    {
        public int EarliestAcq(int[][] logs, int N)
        {
            if (logs.Length < N - 1) return -1;
            logs = logs.OrderBy(log => log[0]).ToArray();

            var uf = new UnionFind(N);
            foreach (var item in logs)
            {
                uf.Union(item[1], item[2]);
                if (uf.Count == 1)
                    return item[0];
            }

            return -1;
        }

        private class UnionFind
        {
            private readonly int[] parents;
            private readonly int[] ranks;

            public UnionFind(int length)
            {
                parents = new int[length];
                ranks = new int[length];
                for (int i = 0; i < length; i++)
                    parents[i] = i;

                Count = length;
            }

            public int Count { get; set; }

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
                if (ranks[pIndex1] > ranks[pIndex2])
                {
                    parents[pIndex2] = pIndex1;
                    ranks[pIndex2]++;
                }
                else
                {
                    parents[pIndex1] = pIndex2;
                    ranks[pIndex1]++;
                }
                Count--;
            }
        }
    }
}
