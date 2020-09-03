//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 24 MB
// Link: https://leetcode.com/submissions/detail/373281127/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0772_BasicCalculatorIII
    {
        public int Calculate(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            var stack = new Stack<int>();
            int num = 0;
            char sign = '+';

            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (char.IsDigit(ch))
                    num = 10 * num + (ch - '0');
                else if (ch == '(')
                {
                    int balance = 1;
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '(') balance++;
                        if (s[j] == ')') balance--;
                        if (balance == 0)
                        {
                            num = Calculate(s.Substring(i + 1, j - i - 1));
                            i = j;
                            break;
                        }
                    }
                }

                if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || i == s.Length - 1)
                {
                    switch (sign)
                    {
                        case '+':
                            stack.Push(num);
                            break;
                        case '-':
                            stack.Push(-num);
                            break;
                        case '*':
                            stack.Push(stack.Pop() * num);
                            break;
                        case '/':
                            stack.Push(stack.Pop() / num);
                            break;
                    }

                    num = 0;
                    sign = ch;
                }
            }

            var result = 0;
            while (stack.Count > 0)
                result += stack.Pop();

            return result;
        }
    }
}
