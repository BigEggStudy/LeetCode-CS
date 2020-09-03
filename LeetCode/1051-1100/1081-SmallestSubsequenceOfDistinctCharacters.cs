//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 22.5 MB
// Link: https://leetcode.com/submissions/detail/379521732/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1081_SmallestSubsequenceOfDistinctCharacters
    {
        public string SmallestSubsequence(string text)
        {
            var indexes = new int[26];
            for (int i = 0; i < text.Length; i++)
                indexes[text[i] - 'a'] = i;

            var seen = new HashSet<char>();
            var stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                if (seen.Contains(ch)) continue;

                while (stack.Count > 0 && stack.Peek() > ch && indexes[stack.Peek() - 'a'] > i)
                    seen.Remove(stack.Pop());

                seen.Add(ch);
                stack.Push(ch);
            }

            var chars = new char[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
                chars[i] = stack.Pop();

            return new string(chars);
        }
    }
}
