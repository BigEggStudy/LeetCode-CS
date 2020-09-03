//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.8 MB
// Link: https://leetcode.com/submissions/detail/335620582/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0266_PalindromePermutation
    {
        public bool CanPermutePalindrome(string s)
        {
            var counts = new int[256];
            foreach (var ch in s)
                counts[ch]++;

            var result = 0;
            foreach (var count in counts)
            {
                if (count % 2 == 0) continue;
                result++;
            }

            return result <= 1;
        }
    }
}
