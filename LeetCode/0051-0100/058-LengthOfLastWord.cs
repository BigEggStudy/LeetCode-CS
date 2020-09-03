//-----------------------------------------------------------------------------
// Runtime: 72msms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/359573650/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _058_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            var index = s.Length - 1;
            while (index >= 0 && s[index] == ' ')
            {
                index--;
            }

            var result = 0;
            while (index >= 0 && s[index] != ' ')
            {
                result++;
                index--;
            }

            return result;
        }
    }
}
