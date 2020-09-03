//-----------------------------------------------------------------------------
// Runtime: 276ms
// Memory Usage: 44.2 MB
// Link: https://leetcode.com/submissions/detail/390181614/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0952_LargestComponentSizeByCommonFactor
    {
        public int LargestComponentSize(int[] A)
        {
            int maxValue = A.Max();
            var uf = new UnionFind(maxValue + 1);

            var numFactorMap = new Dictionary<int, int>();
            foreach (int num in A)
            {
                var primeFactors = PrimeDecompose(num);

                numFactorMap[num] = primeFactors[0];
                for (int i = 0; i < primeFactors.Count - 1; ++i)
                    uf.Union(primeFactors[i], primeFactors[i + 1]);
            }

            // count the size of group one by one
            int maxGroupSize = 0;
            var groupCount = new Dictionary<int, int>();
            foreach (int num in A)
            {
                var groupId = uf.Find(numFactorMap[num]);
                groupCount.TryGetValue(groupId, out int count);
                groupCount[groupId] = count + 1;

                maxGroupSize = Math.Max(maxGroupSize, count + 1);
            }

            return maxGroupSize;
        }

        private IList<int> PrimeDecompose(int num)
        {
            var primeFactors = new List<int>();

            int factor = 2;
            while (num >= factor * factor)
            {
                if (num % factor == 0)
                {
                    primeFactors.Add(factor);
                    num /= factor;
                }
                else
                    factor += 1;
            }

            primeFactors.Add(num);

            return primeFactors.Distinct().ToList();
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
