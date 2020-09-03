//-----------------------------------------------------------------------------
// Runtime: 284ms
// Memory Usage: 38.8 MB
// Link: https://leetcode.com/submissions/detail/352428880/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0989_AddToArrayFormOfInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var result = new List<int>();
            var carry = 0;

            var i = A.Length - 1;
            while (i >= 0 && K > 0)
            {
                var sum = A[i--] + K % 10 + carry;
                K /= 10;

                var digit = sum % 10;
                carry = sum / 10;
                result.Add(digit);
            }

            while (i >= 0)
            {
                var sum = A[i--] + carry;
                var digit = sum % 10;
                carry = sum / 10;
                result.Add(digit);
            }

            while (K > 0)
            {
                var sum = K % 10 + carry;
                K /= 10;
                var digit = sum % 10;
                carry = sum / 10;
                result.Add(digit);
            }

            if (carry > 0)
                result.Add(carry);

            result.Reverse();
            return result;
        }
    }
}
