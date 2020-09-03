//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/358760127/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0507_PerfectNumber
    {
        public bool CheckPerfectNumber(int num)
        {
            int[] primes = new int[] { 2, 3, 5, 7, 13, 17, 19, 31 };
            foreach (int prime in primes)
            {
                if (PN(prime) == num)
                    return true;
            }
            return false;
        }

        private int PN(int p)
        {
            return (1 << (p - 1)) * ((1 << p) - 1);
        }
    }
}
