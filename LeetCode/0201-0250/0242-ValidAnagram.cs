//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/340983796/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _0242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sCount = new int[26];
            foreach (var ch in s)
                sCount[ch - 'a']++;

            var tCount = new int[26];
            foreach (var ch in t)
                tCount[ch - 'a']++;

            return sCount.SequenceEqual(tCount);
        }
    }
}
