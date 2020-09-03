//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 18.5 MB
// Link: https://leetcode.com/submissions/detail/362997490/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0264_UglyNumberII
    {
        private readonly int[] numbers = new int[1690];

        public int NthUglyNumber(int n)
        {
            if (n < 0) return -1;
            if (n == 1) return 1;
            if (numbers[n - 1] > 0) return numbers[n - 1];

            int index2 = 0, index3 = 0, index5 = 0;
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                numbers[i] = Math.Min(Math.Min(numbers[index2] * 2, numbers[index3] * 3), numbers[index5] * 5);
                if (numbers[i] == numbers[index2] * 2) index2++;
                if (numbers[i] == numbers[index3] * 3) index3++;
                if (numbers[i] == numbers[index5] * 5) index5++;
            }

            return numbers[n - 1];
        }
    }
}
