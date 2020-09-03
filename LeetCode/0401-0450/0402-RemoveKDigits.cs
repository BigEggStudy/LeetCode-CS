//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/338962104/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0402_RemoveKDigits
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == 0) return num;
            if (k == num.Length) return "0";

            var stack = new Stack<char>();
            foreach (var ch in num)
            {
                while (k > 0 && stack.Count > 0 && ch < stack.Peek())
                {
                    k--;
                    stack.Pop();
                }
                stack.Push(ch);
            }

            while (k-- > 0 && stack.Count > 0)
                stack.Pop();
            if (stack.Count == 0) return "0";

            var sb = new StringBuilder();
            foreach (var ch in stack)
                sb.Append(ch);

            var result = new StringBuilder();
            bool leadingZero = true;
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                if (leadingZero && sb[i] == '0') { continue; }
                leadingZero = false;
                result.Append(sb[i]);
            }

            return result.Length > 0 ? result.ToString() : "0";
        }
    }
}
