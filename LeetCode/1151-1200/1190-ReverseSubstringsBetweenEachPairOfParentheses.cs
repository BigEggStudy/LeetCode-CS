//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 22.8 MB
// Link: https://leetcode.com/submissions/detail/370341726/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1190_ReverseSubstringsBetweenEachPairOfParentheses
    {
        public string ReverseParentheses(string s)
        {
            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch != ')') stack.Push(ch);
                else
                {
                    var sb = new StringBuilder();
                    while (stack.Peek() != '(')
                        sb.Append(stack.Pop());

                    stack.Pop();
                    foreach (var ch2 in sb.ToString())
                        stack.Push(ch2);
                }
            }

            return string.Join("", stack.Reverse());
        }
    }
}
