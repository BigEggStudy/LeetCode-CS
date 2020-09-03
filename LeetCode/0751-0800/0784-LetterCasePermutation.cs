//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 34.6 MB
// Link: https://leetcode.com/submissions/detail/335014520/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0784_LetterCasePermutation
    {
        public IList<string> LetterCasePermutation(string S)
        {
            List<string> result = new List<string>();

            BackTracking(S, "", result, 0);
            return result;
        }

        public void BackTracking(string input, string current, List<string> result, int index)
        {
            if (current.Length == input.Length)
            {
                result.Add(new string(current.ToCharArray()));
                return;
            }

            char ch = input[index];
            if (char.IsDigit(ch))
            {
                current = string.Concat(current, ch);
                BackTracking(input, current, result, index + 1);
            }
            else
            {
                BackTracking(input, current + char.ToLower(ch), result, index + 1);
                BackTracking(input, current + char.ToUpper(ch), result, index + 1);
            }
        }
    }
}
