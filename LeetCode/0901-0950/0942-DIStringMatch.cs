//-----------------------------------------------------------------------------
// Runtime: 224ms
// Memory Usage: 34.5 MB
// Link: https://leetcode.com/submissions/detail/328324137/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0942_DIStringMatch
    {
        public int[] DiStringMatch(string S)
        {
            var result = new int[S.Length + 1];
            int lo = 0, hi = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I') result[i] = lo++;
                else if (S[i] == 'D') result[i] = hi--;
            }

            result[S.Length] = lo;
            return result;
        }
    }
}
