//-----------------------------------------------------------------------------
// Runtime: 128ms
// Memory Usage: 32.7 MB
// Link: https://leetcode.com/submissions/detail/338633310/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0976_LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            for (int i = A.Length - 3; i >= 0; i--)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                    return A[i] + A[i + 1] + A[i + 2];
            }

            return 0;
        }
    }
}
