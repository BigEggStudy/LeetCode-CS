//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 22.4 MB
// Link: https://leetcode.com/submissions/detail/359575372/
//-----------------------------------------------------------------------------

using System.Numerics;

namespace LeetCode
{
    public class _0686_RepeatedStringMatch
    {
        public int RepeatedStringMatch(string A, string B)
        {
            int q = (B.Length - 1) / A.Length + 1;
            int p = 113, MOD = 1_000_000_007;
            int pInv = (int)BigInteger.ModPow(p, MOD - 2, MOD);

            long bHash = 0, power = 1;
            for (int i = 0; i < B.Length; i++)
            {
                bHash += power * B[i];
                bHash %= MOD;
                power = (power * p) % MOD;
            }

            long aHash = 0; power = 1;
            for (int i = 0; i < B.Length; i++)
            {
                aHash += power * A[i % A.Length];
                aHash %= MOD;
                power = (power * p) % MOD;
            }

            if (aHash == bHash && Check(0, A, B)) return q;
            power = (power * pInv) % MOD;

            for (int i = B.Length; i < (q + 1) * A.Length; i++)
            {
                aHash -= A[(i - B.Length) % A.Length];
                aHash *= pInv;
                aHash += power * A[i % A.Length];
                aHash %= MOD;

                if (aHash == bHash && Check(i - B.Length + 1, A, B))
                    return i < q * A.Length ? q : q + 1;
            }
            return -1;
        }

        private bool Check(int index, string A, string B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                if (A[(i + index) % A.Length] != B[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
