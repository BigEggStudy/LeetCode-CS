//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 35.8 MB
// Link: https://leetcode.com/submissions/detail/330126669/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0922_SortArrayByParityII
    {
        public int[] SortArrayByParityII(int[] A)
        {
            var oddIndex = 1;
            for (int evenIndex = 0; evenIndex < A.Length; evenIndex += 2)
            {
                if (A[evenIndex] % 2 == 1)
                {
                    while (A[oddIndex] % 2 == 1)
                        oddIndex += 2;

                    var temp = A[evenIndex];
                    A[evenIndex] = A[oddIndex];
                    A[oddIndex] = temp;
                }
            }

            return A;
        }
    }
}
