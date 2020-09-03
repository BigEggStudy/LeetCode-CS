//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.2 MB
// Link: https://leetcode.com/submissions/detail/361212490/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1100_FindKLengthSubstringsWithNoRepeatedCharacters
    {
        public int NumKLenSubstrNoRepeats(string S, int K)
        {
            var set = new HashSet<int>();
            int start = 0, result = 0;
            for (int i = 0; i < S.Length; i++)
            {
                while (set.Contains(S[i]))
                    set.Remove(S[start++]);

                set.Add(S[i]);

                if (i - start + 1 == K)
                {
                    result++;
                    set.Remove(S[start++]);
                }
            }

            return result;
        }
    }
}
