//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/submissions/detail/361687922/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1222_QueensThatCanAttackTheKing
    {
        public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            var result = new List<IList<int>>();
            var set = queens.Select(q => (q[0], q[1])).ToHashSet();

            for (int r = -1; r <= 1; r++)
                for (int c = -1; c <= 1; c++)
                    for (int length = 1; length < 8; length++)
                    {
                        var qc = king[1] + c * length;
                        var qr = king[0] + r * length;
                        if (qc < 0 || qc >= 8 || qr < 0 || qr >= 8) break;
                        if (set.Contains((qr, qc)))
                        {
                            result.Add(new int[] { qr, qc });
                            break;
                        }
                    }

            return result;
        }
    }
}
