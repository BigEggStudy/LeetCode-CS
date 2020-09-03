//-----------------------------------------------------------------------------
// Runtime: 292ms
// Memory Usage: 44.2 MB
// Link: https://leetcode.com/submissions/detail/337411482/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0997_FindTheTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            var score = new int[N + 1];
            foreach (var pair in trust)
            {
                score[pair[0]]--;
                score[pair[1]]++;
            }

            for (int i = 1; i < N + 1; i++)
            {
                if (score[i] == N - 1)
                    return i;
            }

            return -1;
        }
    }
}
