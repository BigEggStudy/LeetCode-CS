//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 31.6 MB
// Link: https://leetcode.com/submissions/detail/336944781/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1408_StringMatchingInAnArray
    {
        public IList<string> StringMatching(string[] words)
        {
            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            var result = new List<string>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
