//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 40.5 MB
// Link: https://leetcode.com/submissions/detail/369950110/
//-----------------------------------------------------------------------------

using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1249_MinimumRemoveToMakeValidParentheses
    {
        public string MinRemoveToMakeValid(string s)
        {
            var sb = RemoveInvalidClosing(s.ToArray(), '(', ')');
            sb = RemoveInvalidClosing(sb.ToString().Reverse().ToArray(), ')', '(');
            return new string(sb.ToString().Reverse().ToArray());
        }

        private StringBuilder RemoveInvalidClosing(char[] s, char open, char close)
        {
            var sb = new StringBuilder();
            int balance = 0;

            foreach (var ch in s)
            {
                if (ch == open) balance++;
                if (ch == close)
                {
                    if (balance == 0) continue;
                    balance--;
                }
                sb.Append(ch);
            }
            return sb;
        }
    }
}
