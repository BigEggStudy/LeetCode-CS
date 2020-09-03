//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 27.8 MB
// Link: https://leetcode.com/submissions/detail/352813587/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0849_MaximizeDistanceToClosestPerson
    {
        public int MaxDistToClosest(int[] seats)
        {
            int k = 0, n = seats.Length;
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                if (seats[i] == 1)
                    k = 0;
                else
                {
                    k++;
                    result = Math.Max(result, (k + 1) / 2);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (seats[i] == 1)
                {
                    result = Math.Max(result, i);
                    break;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (seats[i] == 1)
                {
                    result = Math.Max(result, n - i - 1);
                    break;
                }
            }

            return result;
        }
    }
}
