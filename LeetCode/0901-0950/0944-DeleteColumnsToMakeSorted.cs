//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/328766413/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0944_DeleteColumnsToMakeSorted
    {
        public int MinDeletionSize(string[] A)
        {
            var row = A.Length;
            var col = A[0].Length;

            var count = 0;
            for (int i = 0; i < col; i++)
            {
                var current_ch = A[0][i];
                for (int j = 1; j < row; j++)
                {
                    var ch = A[j][i];
                    if (ch < current_ch)
                    {
                        count++;
                        break;
                    }
                    current_ch = ch;
                }
            }

            return count;
        }
    }
}
