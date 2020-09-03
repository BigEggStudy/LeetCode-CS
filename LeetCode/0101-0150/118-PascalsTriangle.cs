//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/344216531/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var results = new List<IList<int>>();
            if (numRows <= 0) return results;
            results.Add(new List<int>(1) { 1 });
            if (numRows == 1) return results;
            results.Add(new List<int>(2) { 1, 1 });
            if (numRows == 2) return results;

            for (int i = 2; i < numRows; i++)
            {
                var result = new List<int>(i + 1);
                result.Add(1);
                for (int j = 1; j < i; j++)
                {
                    result.Add(results[i - 1][j - 1] + results[i - 1][j]);
                }
                result.Add(1);
                results.Add(result);
            }
            return results;
        }
    }
}
