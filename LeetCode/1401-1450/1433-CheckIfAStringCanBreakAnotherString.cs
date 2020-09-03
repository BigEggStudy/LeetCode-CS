//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 33.5 MB
// Link: https://leetcode.com/submissions/detail/364010766/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1433_CheckIfAStringCanBreakAnotherString
    {
        public bool CheckIfCanBreak(string s1, string s2)
        {
            var count1 = new int[26];
            foreach (var ch in s1)
                count1[ch - 'a']++;
            var count2 = new int[26];
            foreach (var ch in s2)
                count2[ch - 'a']++;

            return Check(count1, count2) || Check(count2, count1);
        }

        private bool Check(int[] count1, int[] count2)
        {
            var result = 0;
            for (int i = 0; i < 26; i++)
            {
                result += count1[i] - count2[i];
                if (result < 0)
                    return false;
            }

            return true;
        }
    }
}
