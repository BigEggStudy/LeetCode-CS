//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/352778888/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _067_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            var carry = 0;
            var builder = new StringBuilder();

            var aLength = a.Length - 1;
            var bLength = b.Length - 1;

            int aVal, bVal, val;
            while (aLength >= 0 || bLength >= 0)
            {
                aVal = aLength >= 0 ? a[aLength] - '0' : 0;
                bVal = bLength >= 0 ? b[bLength] - '0' : 0;

                val = aVal + bVal + carry;
                builder.Insert(0, val & 1);

                carry = val >> 1;

                aLength--;
                bLength--;
            }

            if (carry >= 1)
            {
                builder.Insert(0, carry);
            }

            return builder.ToString();
        }
    }
}
