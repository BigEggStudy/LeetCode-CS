//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 33.2 MB
// Link: https://leetcode.com/submissions/detail/359259406/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0941_ValidMountainArray
    {
        public bool ValidMountainArray(int[] A)
        {
            int i = 0, N = A.Length;

            while (i + 1 < N && A[i] < A[i + 1])
                i++;

            if (i == 0 || i == N - 1) return false;

            while (i + 1 < N && A[i] > A[i + 1])
                i++;

            return i == N - 1;
        }
    }
}
