//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 23.7 MB
// Link: https://leetcode.com/submissions/detail/341590841/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0567_PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var s1Length = s1.Length;
            var s2Length = s2.Length;

            if (s1Length > s2Length) return false;

            var s1Count = new int[26];
            foreach (var ch in s1)
                s1Count[ch - 'a']++;

            var s2Count = new int[26];
            for (int i = 0; i < s2Length; i++)
            {
                s2Count[s2[i] - 'a']++;
                if (i >= s1Length)
                    s2Count[s2[i - s1Length] - 'a']--;

                if (s2Count.SequenceEqual(s1Count))
                    return true;
            }

            return false;
        }
    }
}
