//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/327840710/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0905_SortArrayByParity
    {
        public int[] SortArrayByParity(int[] A)
        {
            int left = 0;
            int right = A.Length - 1;
            while (left < right)
            {
                while (left < right && A[left] % 2 == 0) left++;
                while (left < right && A[right] % 2 == 1) right--;

                var temp = A[left];
                A[left] = A[right];
                A[right] = temp;
            }

            return A;
        }
    }
}
