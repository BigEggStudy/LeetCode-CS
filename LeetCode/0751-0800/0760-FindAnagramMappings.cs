//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30 MB
// Link: https://leetcode.com/submissions/detail/326845848/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0760_FindAnagramMappings
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            var list = new List<int>(B);

            var result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
                result[i] = list.IndexOf(A[i]);

            return result;
        }
    }
}
