//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _120_Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0) return 0;
            
            for (int i = 1; i < triangle.Count; i++)
                for (int j = 0; j <= i; j++)
                    if (j == 0)
                        triangle[i][j] += triangle[i - 1][j];
                    else if (j == i)
                        triangle[i][j] += triangle[i - 1][j - 1];
                    else
                        triangle[i][j] += Math.Min(triangle[i - 1][j], triangle[i - 1][j - 1]);

            return triangle.Last().Min();
        }
    }
}
