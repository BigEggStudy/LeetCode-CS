//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 27.9 MB
// Link: https://leetcode.com/submissions/detail/339610870/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0748_ShortestCompletingWord
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var target = CountWord(licensePlate.ToLower());
            var result = string.Empty;
            foreach (var word in words)
            {
                if (word.Length < result.Length || result.Length == 0)
                {
                    var current = CountWord(word);
                    var match = true;
                    for (int i = 0; i < 26; i++)
                    {
                        if (current[i] < target[i])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                        result = word;
                }
            }

            return result;
        }

        private int[] CountWord(string word)
        {
            var count = new int[26];
            foreach (var ch in word)
                if (char.IsLetter(ch)) count[ch - 'a']++;

            return count;
        }
    }
}
