//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/327846475/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0728_SelfDividingNumbers
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>();
            for (int i = left; i <= right; i++)
                if (IsSelfDividing(i))
                    result.Add(i);

            return result;
        }

        private bool IsSelfDividing(int num)
        {
            if (num > 0 && num < 9) return true;

            var number = num;
            while (num > 0)
            {
                var current = num % 10;
                if ((current == 0) || (number % current != 0))
                    return false;

                num /= 10;
            }
            return true;
        }
    }
}
