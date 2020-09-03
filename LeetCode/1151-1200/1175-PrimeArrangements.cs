//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 15.4 MB
// Link: https://leetcode.com/submissions/detail/344247885/
//-----------------------------------------------------------------------------

using System.Linq;

namespace LeetCode
{
    public class _1175_PrimeArrangements
    {
        private readonly int MOD = 1000000007;

        public int NumPrimeArrangements(int n)
        {
            var primes = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                primes[i] = true;

            for (int i = 2; i * i <= n; i++)
                if (primes[i])
                    for (int j = i * i; j <= n; j += i)
                        primes[j] = false;

            var primeCount = primes.Count(p => p);

            long result = 1;
            for (int i = 2; i <= primeCount; i++)
                result = (result * i) % MOD;
            for (int i = 2; i <= n - primeCount; i++)
                result = (result * i) % MOD;

            return (int)result;
        }
    }
}
