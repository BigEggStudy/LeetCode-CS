//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.3 MB
// Link: https://leetcode.com/submissions/detail/261480462/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0771_JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var map = new Dictionary<char, int>();
            foreach (var ch in J)
                map.Add(ch, 0);

            int result = 0;
            foreach (var ch in S)
                if (map.ContainsKey(ch)) result++;

            return result;
        }
    }
}
