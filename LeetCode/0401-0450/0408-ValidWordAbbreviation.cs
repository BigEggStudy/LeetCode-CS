//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/359604383/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0408_ValidWordAbbreviation
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int i = 0, j = 0;
            while (i < word.Length && j < abbr.Length)
            {
                if (abbr[j] >= 'a' && abbr[j] <= 'z')
                {
                    if (word[i] != abbr[j]) return false;
                    i++;
                    j++;
                }
                else
                {
                    var count = 0;
                    while (j < abbr.Length && abbr[j] >= '0' && abbr[j] <= '9')
                    {
                        if (abbr[j] == '0' && count == 0) return false;
                        count *= 10;
                        count += abbr[j] - '0';
                        j++;
                    }

                    i += count;
                }
            }

            return i == word.Length && j == abbr.Length;
        }
    }
}
