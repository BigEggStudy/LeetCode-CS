//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 23.3 MB
// Link: https://leetcode.com/submissions/detail/359606360/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0859_BuddyStrings
    {
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length) return false;
            if (A == B)
            {
                int[] counts = new int[26];
                for (int i = 0; i < A.Length; ++i)
                    counts[A[i] - 'a']++;

                foreach (int c in counts)
                    if (c > 1) return true;
                return false;
            }

            int first = -1, second = -1;
            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] != B[i])
                {
                    if (first == -1)
                        first = i;
                    else if (second == -1)
                        second = i;
                    else
                        return false;
                }
            }

            return second != -1 && A[first] == B[second] && A[second] == B[first];
        }
    }
}
