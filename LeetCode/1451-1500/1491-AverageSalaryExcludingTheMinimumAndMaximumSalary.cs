//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/359218879/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary
    {
        public double Average(int[] salary)
        {
            int sum = 0, min = int.MaxValue, max = int.MinValue;
            foreach (var num in salary)
            {
                if (num < min) min = num;
                if (num > max) max = num;

                sum += num;
            }

            return (sum - min - max) * 1.0 / (salary.Length - 2);
        }
    }
}
