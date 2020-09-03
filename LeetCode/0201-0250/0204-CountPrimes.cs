//-----------------------------------------------------------------------------
// Runtime: 60ms
// Memory Usage: 16.9 MB
// Link: https://leetcode.com/submissions/detail/359591685/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0204_CountPrimes
    {
        public int CountPrimes(int n)
        {
            var notPrime = new bool[n];
            var count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!notPrime[i])
                {
                    count++;
                    for (int j = 2; j * i < n; j++)
                        notPrime[i * j] = true;
                }
            }

            return count;
        }
    }
}
