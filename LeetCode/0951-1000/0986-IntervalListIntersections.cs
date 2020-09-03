//-----------------------------------------------------------------------------
// Runtime: 268ms
// Memory Usage: 35.7 MB
// Link: https://leetcode.com/submissions/detail/343611260/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0986_IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var result = new List<int[]>();
            int i = 0, j = 0;

            while (i < A.Length && j < B.Length)
            {
                var lo = Math.Max(A[i][0], B[j][0]);
                var hi = Math.Min(A[i][1], B[j][1]);
                if (lo <= hi)
                    result.Add(new int[] { lo, hi });

                if (A[i][1] < B[j][1])
                    i++;
                else
                    j++;
            }

            return result.ToArray();
        }
    }
}
