//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/358370209/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0422_ValidWordSquare
    {
        public bool ValidWordSquare(IList<string> words)
        {
            if (words == null || words.Count == 0) return true;

            var n = words.Count;
            for (int i = 0; i < n; i++)
            {
                var str1 = words[i];

                for (int j = 0; j < str1.Length; j++)
                {
                    if (j >= n) return false;

                    var str2 = words[j];
                    if (str2.Length <= i || str1[j] != str2[i])
                        return false;
                }
            }

            return true;
        }
    }
}
