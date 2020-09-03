//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/332566152/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1025_DivisorGame
    {
        public bool DivisorGame(int N)
        {
            if (N == 1) return false;
            if (N == 2) return true;

            var result = new bool[N + 1];
            result[1] = false;
            result[2] = true;
            for (int i = 3; i <= N; i++)
            {
                var bobWin = true;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        bobWin = bobWin && result[i - j];

                    if (!bobWin) break;
                }

                result[i] = !bobWin;
            }

            return result[N];
        }
    }
}
