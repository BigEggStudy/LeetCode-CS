//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 23 MB
// Link: https://leetcode.com/submissions/detail/352336254/
//-----------------------------------------------------------------------------

using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0504_Base7
    {
        public string ConvertToBase7(int num)
        {
            if (num == 0) return "0";

            var signal = num < 0;
            if (num < 0) num = -num;

            var sb = new StringBuilder();
            while (num > 0)
            {
                sb.Append((num % 7).ToString());
                num /= 7;
            }
            if (signal)
                sb.Append('-');

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
