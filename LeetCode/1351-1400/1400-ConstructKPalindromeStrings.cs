//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 34.5 MB
// Link: https://leetcode.com/submissions/detail/371229258/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1400_ConstructKPalindromeStrings
    {
        public bool CanConstruct(string s, int k)
        {
            var count = new int[26];
            foreach (var ch in s)
                count[ch - 'a']++;

            int sum = 0, oddCount = 0;
            for (int i = 0; i < 26; i++)
            {
                sum += count[i];
                oddCount += count[i] % 2 == 1 ? 1 : 0;
            }

            return sum >= k && oddCount <= k;
        }
    }
}
