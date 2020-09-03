//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 21.8 MB
// Link: https://leetcode.com/submissions/detail/327556518/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1180_CountSubstringsWithOnlyOneDistinctLetter
    {
        public int CountLetters(string S)
        {
            int left = 0;
            int right = 0;
            int result = 0;

            while (left != S.Length)
            {
                if (right == S.Length || S[right] != S[left])
                {
                    int length = (right - left);
                    result += (1 + length) * length / 2;
                    left = right;
                }
                else
                    right++;
            }

            return result;
        }
    }
}
