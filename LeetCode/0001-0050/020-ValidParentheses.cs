//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/358336005/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                    stack.Push(ch);
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count <= 0) return false;
                    var lastCh = stack.Peek();

                    if ((ch == ')' && lastCh == '(') ||
                        (ch == ']' && lastCh == '[') ||
                        (ch == '}' && lastCh == '{'))
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
