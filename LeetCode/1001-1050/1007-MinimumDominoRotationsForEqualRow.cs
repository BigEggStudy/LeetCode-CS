//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1007_MinimumDominoRotationsForEqualRow
    {
        public int MinDominoRotations(int[] A, int[] B)
        {
            var result = CheckMinDominoRotations(A[0], A, B);
            if (result != -1 || A[0] == B[0]) return result;
            return CheckMinDominoRotations(B[0], A, B);
        }

        public int CheckMinDominoRotations(int x, int[] A, int[] B)
        {
            int rotateA = 0, rotateB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != x && B[i] != x) return -1;
                else if (A[i] != x) rotateA++;
                else if (B[i] != x) rotateB++;
            }

            return Math.Min(rotateA, rotateB);
        }
    }
}
