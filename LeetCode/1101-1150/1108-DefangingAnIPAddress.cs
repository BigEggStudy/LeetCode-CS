//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 22.5 MB
// Link: https://leetcode.com/submissions/detail/326410370/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1108_DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            var sb = new StringBuilder();
            foreach (var ch in address)
            {
                if (ch == '.')
                    sb.Append("[.]");
                else
                    sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
