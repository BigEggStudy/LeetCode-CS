//-----------------------------------------------------------------------------
// Runtime: 284ms
// Memory Usage: 39.9 MB
// Link: https://leetcode.com/submissions/detail/328294820/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0977_SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            var left = 0;
            var right = A.Length - 1;

            var result = new int[A.Length];
            var current = right;

            while (left <= right)
            {
                if (Math.Abs(A[left]) > Math.Abs(A[right]))
                {
                    result[current--] = A[left] * A[left];
                    left++;
                }
                else
                {
                    result[current--] = A[right] * A[right];
                    right--;
                }
            }

            return result;
        }
    }
}
