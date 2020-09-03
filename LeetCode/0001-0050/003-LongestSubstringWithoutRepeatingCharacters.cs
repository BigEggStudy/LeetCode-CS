//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/375123949/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var map = new Dictionary<int, int>();
            var maxLen = 0;
            var lastRepeatPos = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]) && lastRepeatPos < map[s[i]])
                    lastRepeatPos = map[s[i]];
                if (maxLen < i - lastRepeatPos)
                    maxLen = i - lastRepeatPos;
                map[s[i]] = i;
            }

            return maxLen;
        }
    }
}
