//-----------------------------------------------------------------------------
// Runtime: 196ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/351846277/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _119_PascalsTriangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new int[rowIndex + 1];
            result[0] = 1;
            if (rowIndex == 0) return result;

            for (int i = 1; i <= rowIndex; i++)
                for (int j = i; j > 0; j--)
                    result[j] = result[j - 1] + result[j];

            return result;
        }
    }
}
