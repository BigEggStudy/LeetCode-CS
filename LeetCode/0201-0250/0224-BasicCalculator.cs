//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/371999150/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0224_BasicCalculator
    {
        public int Calculate(string s)
        {
            var stack = new Stack<int>();
            int num = 0;
            var sign = 1;

            var result = 0;
            foreach (var ch in s)
            {
                if (char.IsDigit(ch))
                    num = 10 * num + (ch - '0');
                else if (ch == '+')
                {
                    result += sign * num;
                    sign = 1;
                    num = 0;
                }
                else if (ch == '-')
                {
                    result += sign * num;
                    sign = -1;
                    num = 0;
                }
                else if (ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);

                    sign = 1;
                    num = 0;
                    result = 0;
                }
                else if (ch == ')')
                {
                    result += sign * num;

                    num = result;
                    sign = stack.Pop();
                    result = stack.Pop();
                }
            }

            return result + sign * num;
        }
    }
}
