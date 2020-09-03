//-----------------------------------------------------------------------------
// Runtime: 620ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0336_PalindromePairs
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            if (words == null || words.Length < 2) return new List<IList<int>>();

            var result = new HashSet<IList<int>>();
            var map = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++) map.Add(words[i], i);

            for (int i = 0; i < words.Length; i++)
            {
                if (string.IsNullOrEmpty(words[i])) continue;

                for (int j = 0; j <= words[i].Length; j++)
                {
                    var prefix = words[i].Substring(0, j);
                    var surfix = words[i].Substring(j);

                    if (IsPalindrome(prefix))
                    {
                        var surfixReverse = ReverseString(surfix);
                        if (map.ContainsKey(surfixReverse) && map[surfixReverse] != i)
                            result.Add(new List<int>() { map[surfixReverse], i });
                    }
                    if (IsPalindrome(surfix))
                    {
                        var prefixReverse = ReverseString(prefix);
                        if (map.ContainsKey(prefixReverse) && map[prefixReverse] != i && !string.IsNullOrEmpty(surfix))
                            result.Add(new List<int>() { i, map[prefixReverse] });
                    }
                }
            }
            return new List<IList<int>>(result);
        }

        private string ReverseString(string str)
        {
            var sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
                sb.Append(str[i]);

            return sb.ToString();
        }


        private bool IsPalindrome(string str)
        {
            int left = 0, right = str.Length - 1;
            while (left <= right)
                if (str[left++] != str[right--]) return false;

            return true;
        }
    }
}
