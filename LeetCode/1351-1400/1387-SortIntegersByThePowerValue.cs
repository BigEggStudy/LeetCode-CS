//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 16.2 MB
// Link: https://leetcode.com/submissions/detail/361296227/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1387_SortIntegersByThePowerValue
    {
        public int GetKth(int lo, int hi, int k)
        {
            var list = new List<(int num, int powerValue)>();
            for (int i = lo; i <= hi; i++)
                list.Add((i, PowerValue(i)));
            list.Sort((a, b) => a.powerValue == b.powerValue ? a.num.CompareTo(b.num) : a.powerValue.CompareTo(b.powerValue));

            return list[k - 1].num;
        }

        private int PowerValue(int num)
        {
            int count = 0;
            while (num != 1)
            {
                num = num % 2 == 0 ? num / 2 : (num * 3 + 1);
                count++;
            }

            return count;
        }
    }
}
