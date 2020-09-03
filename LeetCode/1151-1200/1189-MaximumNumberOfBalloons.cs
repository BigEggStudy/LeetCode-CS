//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 22.3 MB
// Link: https://leetcode.com/submissions/detail/335642265/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1189_MaximumNumberOfBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            var counts = new int[26];
            foreach (var ch in text)
                counts[ch - 'a']++;

            var result = 0;
            while (true)
            {
                if (counts[0] > 0 && counts[1] > 0 && counts[11] > 1 && counts[13] > 0 && counts[14] > 1)
                {
                    result++;
                    counts[0]--;
                    counts[1]--;
                    counts[11] -= 2;
                    counts[13]--;
                    counts[14] -= 2;
                }
                else
                    break;
            }
            return result;
        }
    }
}
