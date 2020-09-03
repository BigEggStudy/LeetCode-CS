//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/360474031/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0544_OutputContestMatches
    {
        public string FindContestMatch(int n)
        {
            var team = new string[n];
            for (int i = 0; i < n; i++)
                team[i] = (i + 1).ToString();

            while (n > 1)
            {
                for (int i = 0; i < n / 2; i++)
                    team[i] = $"({team[i]},{team[n - 1 - i]})";

                n /= 2;
            }

            return team[0];
        }
    }
}
