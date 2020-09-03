//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.9 MB
// Link: https://leetcode.com/submissions/detail/327396470/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1134_ArmstrongNumber
    {
        public bool IsArmstrong(int N)
        {
            int num = N;
            int length = (int)(Math.Log10(num) + 1);

            double sum = 0;
            while (num > 0)
            {
                int currentDigit = num % 10;
                sum += Math.Pow(currentDigit, length);
                num /= 10;
            }

            return sum == N;
        }
    }
}
