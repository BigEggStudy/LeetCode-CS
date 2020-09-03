//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/352313138/
//-----------------------------------------------------------------------------

using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _0415_AddStrings
    {
        public string AddStrings(string num1, string num2)
        {
            var sb = new StringBuilder();
            int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
            while (i >= 0 && j >= 0)
            {
                var value = num1[i--] - '0' + num2[j--] - '0' + carry;

                var digit = value % 10;
                carry = value / 10;

                sb.Append(digit);
            }

            while (i >= 0)
            {
                var value = num1[i--] - '0' + carry;
                var digit = value % 10;
                carry = value / 10;
                sb.Append(digit);
            }

            while (j >= 0)
            {
                var value = num2[j--] - '0' + carry;
                var digit = value % 10;
                carry = value / 10;
                sb.Append(digit);
            }

            if (carry != 0)
                sb.Append(carry);

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
