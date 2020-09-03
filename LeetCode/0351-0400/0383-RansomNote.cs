//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 27.3 MB
// Link: https://leetcode.com/submissions/detail/334142327/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0383_RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var counts = new int[26];
            foreach (var ch in magazine)
                counts[ch - 'a']++;

            foreach (var ch in ransomNote)
            {
                if (counts[ch - 'a'] == 0)
                    return false;
                counts[ch - 'a']--;
            }

            return true;
        }
    }
}
