//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.6 MB
// Link: https://leetcode.com/submissions/detail/379053111/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0301_RemoveInvalidParentheses
    {
        public IList<string> RemoveInvalidParentheses(string s)
        {
            int invalidLeft = 0, invalidRight = 0;
            foreach (var ch in s)
            {
                if (ch == '(') invalidLeft++;
                else if (ch == ')')
                {
                    invalidRight = invalidLeft == 0 ? invalidRight + 1 : invalidRight;
                    invalidLeft = invalidLeft == 0 ? invalidLeft : invalidLeft - 1;
                }
            }

            var result = new HashSet<string>();
            RemoveInvalidParentheses(s, 0, 0, 0, invalidLeft, invalidRight, new StringBuilder(), result);
            return new List<string>(result);
        }

        private void RemoveInvalidParentheses(string s, int index, int leftCount, int rightCount, int invalidLeft, int invalidRight, StringBuilder sb, HashSet<string> result)
        {
            if (s.Length == index)
            {
                if (invalidLeft == 0 && invalidRight == 0) result.Add(sb.ToString());
                return;
            }

            var ch = s[index];
            if ((ch == '(' && invalidLeft > 0) || (ch == ')' && invalidRight > 0))
                RemoveInvalidParentheses(s, index + 1, leftCount, rightCount, invalidLeft - (ch == '(' ? 1 : 0), invalidRight - (ch == ')' ? 1 : 0), sb, result);

            sb.Append(ch);

            if (ch != '(' && ch != ')')
                RemoveInvalidParentheses(s, index + 1, leftCount, rightCount, invalidLeft, invalidRight, sb, result);
            else if (ch == '(')
                RemoveInvalidParentheses(s, index + 1, leftCount + 1, rightCount, invalidLeft, invalidRight, sb, result);
            else if (rightCount < leftCount)
                RemoveInvalidParentheses(s, index + 1, leftCount, rightCount + 1, invalidLeft, invalidRight, sb, result);

            sb.Remove(sb.Length - 1, 1);
        }
    }
}
