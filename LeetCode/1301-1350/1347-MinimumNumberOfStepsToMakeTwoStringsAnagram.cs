//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 40.4 MB
// Link: https://leetcode.com/submissions/detail/360487475/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1347_MinimumNumberOfStepsToMakeTwoStringsAnagram
    {
        public int MinSteps(string s, string t)
        {
            var counts = new int[26];
            foreach (var ch in s)
                counts[ch - 'a']++;
            foreach (var ch in t)
                if (counts[ch - 'a'] > 0)
                    counts[ch - 'a']--;

            var sum = 0;
            foreach (var count in counts)
                sum += count;

            return sum;
        }
    }
}
