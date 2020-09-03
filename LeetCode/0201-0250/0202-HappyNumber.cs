//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 16.1 MB
// Link: https://leetcode.com/submissions/detail/261183730/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0202_HappyNumber
    {
        public bool IsHappy(int n)
        {
            var map = new HashSet<int>();

            while (!map.Contains(n))
            {
                map.Add(n);
                var newValue = 0;
                while (n > 0)
                {
                    var digit = n % 10;
                    newValue += digit * digit;
                    n /= 10;
                }

                if (newValue == 1) return true;
                n = newValue;
            }

            return false;
        }
    }
}
