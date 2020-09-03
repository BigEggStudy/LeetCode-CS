//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/344226744/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1005_MaximizeSumOfArrayAfterKNegations
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            var list = new SortedList<int, int>(A.Length);
            var sum = 0;
            foreach (var num in A)
            {
                if (!list.ContainsKey(num))
                    list.Add(num, 1);
                else
                    list[num]++;
                sum += num;
            }

            for (int i = 0; i < K; i++)
            {
                var num = list.First().Key;
                if (num == 0) break;

                sum -= num * 2;
                list[num]--;
                if (list[num] == 0)
                    list.Remove(num);

                if (!list.ContainsKey(-num))
                    list.Add(-num, 1);
                else
                    list[-num]++;
            }

            return sum;
        }
    }
}
