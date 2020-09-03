//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 31.6 MB
// Link: https://leetcode.com/submissions/detail/334972755/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0387_FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            var counts = new int[26];
            foreach (var ch in s)
                counts[ch - 'a']++;

            for (int i = 0; i < s.Length; i++)
                if (counts[s[i] - 'a'] == 1)
                    return i;

            return -1;
        }
    }
}
