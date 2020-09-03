//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 15.7 MB
// Link: https://leetcode.com/submissions/detail/371094062/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK
    {
        public int FindMinFibonacciNumbers(int k)
        {
            var fib = new List<int>() { 1, 1 };
            while (fib.Last() < k)
            {
                var size = fib.Count;
                fib.Add(fib[size - 1] + fib[size - 2]);
            }

            int left = 0, right = fib.Count - 1;
            int count = 0;
            while (k > 0)
            {
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    if (fib[mid] == k) return count + 1;
                    else if (fib[mid] < k) left = mid + 1;
                    else right = mid - 1;
                }

                k -= fib[left - 1];
                left = 0;
                count++;
            }

            return count;
        }
    }
}
