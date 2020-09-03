//-----------------------------------------------------------------------------
// Runtime: 464ms
// Memory Usage: 45 MB
// Link: https://leetcode.com/submissions/detail/361692759/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1310_XORQueriesOfASubarray
    {
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            for (int i = 1; i < arr.Length; i++)
                arr[i] ^= arr[i - 1];

            var result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i][0] == 0)
                    result[i] = arr[queries[i][1]];
                else
                    result[i] = arr[queries[i][1]] ^ arr[queries[i][0] - 1];
            }

            return result;
        }
    }
}
