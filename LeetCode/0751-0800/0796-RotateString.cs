//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 21.8 MB
// Link: https://leetcode.com/submissions/detail/344811594/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0796_RotateString
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length) return false;
            if (A.Length < 2) return true;

            var shifts = new int[A.Length + 1];
            for (int i = 0; i <= A.Length; i++)
                shifts[i] = 1;
            for (int left = -1, right = 0; right < A.Length; left++, right++)
            {
                while (left >= 0 && A[left] != A[right])
                    left -= shifts[left];
                shifts[right + 1] = right - left;
            }

            var index = 0;
            foreach (var ch in A + A)
            {
                while (index >= 0 && B[index] != ch)
                    index -= shifts[index];
                index++;
                if (index == A.Length) return true;
            }

            return false;
        }
    }
}
