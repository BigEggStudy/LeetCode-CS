//-----------------------------------------------------------------------------
// Runtime: 372ms
// Memory Usage: 48 MB
// Link: https://leetcode.com/submissions/detail/335604785/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0985_SumOfEvenNumbersAfterQueries
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var sum = A.Where(num => num % 2 == 0).Sum();
            var result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int val = queries[i][0], index = queries[i][1];
                if (A[index] % 2 == 0)
                    sum -= A[index];

                A[index] += val;

                if (A[index] % 2 == 0)
                    sum += A[index];

                result[i] = sum;
            }

            return result;
        }
    }
}
