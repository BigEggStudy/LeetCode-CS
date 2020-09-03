//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 23.6 MB
// Link: https://leetcode.com/submissions/detail/364037143/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1061_LexicographicallySmallestEquivalentString
    {
        public string SmallestEquivalentString(string A, string B, string S)
        {
            var uf = new UnionFind(26);
            for (int i = 0; i < A.Length; i++)
                uf.Union(A[i] - 'a', B[i] - 'a');

            var sb = new StringBuilder(S.Length);
            foreach (var ch in S)
                sb.Append((char)(uf.Find(ch - 'a') + 'a'));

            return sb.ToString();
        }

        private class UnionFind
        {
            private readonly int[] parents;

            public UnionFind(int count)
            {
                this.parents = new int[count];
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
                if (pIndex1 < pIndex2)
                    parents[pIndex2] = pIndex1;
                else
                    parents[pIndex1] = pIndex2;
            }
        }
    }
}
