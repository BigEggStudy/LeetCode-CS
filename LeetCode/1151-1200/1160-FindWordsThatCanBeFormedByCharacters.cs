//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 36.1 MB
// Link: https://leetcode.com/submissions/detail/330701935/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1160_FindWordsThatCanBeFormedByCharacters
    {
        public int CountCharacters(string[] words, string chars)
        {
            if (string.IsNullOrWhiteSpace(chars)) return 0;

            var charMap = new int[26];
            foreach (var ch in chars)
                charMap[ch - 'a']++;

            var result = 0;
            var temp = new int[26];
            foreach (var word in words)
            {
                charMap.CopyTo(temp, 0);

                var isGood = true;
                foreach (var ch in word)
                {
                    if (temp[ch - 'a'] > 0)
                        temp[ch - 'a']--;
                    else
                    {
                        isGood = false;
                        break;
                    }
                }

                if (isGood) result += word.Length;
            }

            return result;
        }
    }
}
