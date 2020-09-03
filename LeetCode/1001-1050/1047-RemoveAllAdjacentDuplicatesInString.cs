//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 29.9 MB
// Link: https://leetcode.com/submissions/detail/330710190/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string S)
        {
            var sb = new StringBuilder();

            foreach (var ch in S)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == ch)
                    sb.Remove(sb.Length - 1, 1);
                else
                    sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
