//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/371212799/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0856_ScoreOfParentheses
    {
        public int ScoreOfParentheses(string S)
        {
            var balance = 0;
            var result = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(') balance++;
                else
                {
                    balance--;
                    if (S[i - 1] == '(')
                        result += 1 << balance;
                }
            }

            return result;
        }
    }
}
