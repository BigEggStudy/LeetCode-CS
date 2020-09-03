//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage:
// Link: https://leetcode.com/submissions/detail/379046685/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0394_DecodeString
    {
        public string DecodeString(string s)
        {
            var countStack = new Stack<int>();
            var strStack = new Stack<string>();

            var sb = new StringBuilder();
            var num = 0;
            foreach (var ch in s)
            {
                if (char.IsDigit(ch))
                    num = num * 10 + ch - '0';
                else if (ch == '[')
                {
                    strStack.Push(sb.ToString());
                    countStack.Push(num);
                    sb.Clear();
                    num = 0;
                }
                else if (ch == ']')
                {
                    var str = sb.ToString();
                    sb.Clear();
                    sb.Append(strStack.Pop());

                    var count = countStack.Pop();
                    for (int i = 0; i < count; i++)
                        sb.Append(str);
                }
                else
                    sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
