//-----------------------------------------------------------------------------
// Runtime: 208ms
// Memory Usage: 26 MB
// Link: https://leetcode.com/submissions/detail/382904466/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0967_NumbersWithSameConsecutiveDifferences
    {
        public int[] NumsSameConsecDiff(int N, int K)
        {
            var resutls = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 2; i <= N; i++)
            {
                var temp = new List<int>();
                foreach (var num in resutls)
                {
                    var digit = num % 10;
                    if (num > 0 && K > 0 && digit - K >= 0)
                        temp.Add(num * 10 + digit - K);
                    if (num > 0 && digit + K < 10)
                        temp.Add(num * 10 + digit + K);
                }
                resutls = temp;
            }
            return resutls.ToArray();
        }
    }
}
