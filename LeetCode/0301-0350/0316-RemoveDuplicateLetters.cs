//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0316_RemoveDuplicateLetters
    {
        public string RemoveDuplicateLetters(string s)
        {
            var indexes = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
                indexes[s[i]] = i;

            var seen = new HashSet<char>();
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (!seen.Contains(ch))
                {
                    while (stack.Count > 0 && stack.Peek() > ch && i < indexes[stack.Peek()])
                        seen.Remove(stack.Pop());

                    seen.Add(ch);
                    stack.Push(ch);
                }
            }

            var str = new char[stack.Count];
            int index = stack.Count - 1;
            foreach (var ch in stack)
                str[index--] = ch;
            return new string(str);
        }
    }
}
