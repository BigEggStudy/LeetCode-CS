//-----------------------------------------------------------------------------
// Runtime: 368ms
// Memory Usage: 41.5 MB
// Link: https://leetcode.com/submissions/detail/371105222/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1447_SimplifiedFractions
    {
        public IList<string> SimplifiedFractions(int n)
        {
            var result = new List<string>();

            for (int i = 2; i <= n; i++)
                for (int j = 1; j < i; j++)
                {
                    if (IsCooprime(i, j))
                        result.Add($"{j}/{i}");
                }

            return result;
        }
        private bool IsCooprime(int a, int b)
        {
            return GCD(a, b) == 1;
        }

        private int GCD(int a, int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }
    }
}
