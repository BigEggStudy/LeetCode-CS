//-----------------------------------------------------------------------------
// Runtime: 320ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/344234305/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0661_ImageSmoother
    {
        public int[][] ImageSmoother(int[][] M)
        {
            var rows = M.Length;
            var cols = M[0].Length;
            int[][] answer = new int[rows][];

            for (var r = 0; r < rows; ++r)
            {
                answer[r] = new int[cols];
                for (var c = 0; c < cols; ++c)
                {
                    int count = 0;
                    for (var nr = r - 1; nr <= r + 1; nr++)
                        for (var nc = c - 1; nc <= c + 1; nc++)
                        {
                            if (0 <= nr && nr < rows && 0 <= nc && nc < cols)
                            {
                                answer[r][c] += M[nr][nc];
                                count++;
                            }
                        }
                    answer[r][c] /= count;
                }
            }
            return answer;
        }
    }
}
