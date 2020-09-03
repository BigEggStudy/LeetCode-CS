//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 30.9 MB
// Link: https://leetcode.com/submissions/detail/363023872/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0969_PancakeSorting
    {
        public IList<int> PancakeSort(int[] A)
        {
            var result = new List<int>();
            for (int x = A.Length; x > 0; x--)
            {
                int index = 0;
                while (A[index] != x) index++;
                if (index + 1 == x) continue;

                Flip(A, index + 1);
                result.Add(index + 1);

                Flip(A, x);
                result.Add(x);
            }

            return result;
        }

        private void Flip(int[] a, int k)
        {
            for (int i = 0, j = k - 1; i < j; i++, j--)
            {
                var temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}
