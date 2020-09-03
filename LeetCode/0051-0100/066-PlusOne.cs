//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/352820219/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            var result = new List<int>();

            var carry = 1;
            var value = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                value = digits[i] + carry;
                carry = value == 10 ? 1 : 0;
                result.Insert(0, value % 10);
            }

            if (carry >= 1)
                result.Insert(0, carry);

            return result.ToArray();
        }
    }
}
