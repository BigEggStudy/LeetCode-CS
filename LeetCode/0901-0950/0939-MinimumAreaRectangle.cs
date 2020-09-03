//-----------------------------------------------------------------------------
// Runtime: 352ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0939_MinimumAreaRectangle
    {
        public int MinAreaRect(int[][] points)
        {
            var pointSet = new HashSet<int>();
            foreach (var point in points)
                pointSet.Add(40001 * point[0] + point[1]);

            var result = int.MaxValue;
            for (int i = 0; i < points.Length; i++)
                for (int j = i + 1; j < points.Length; j++)
                    if (points[i][0] != points[j][0] && points[i][1] != points[j][1])
                        if (pointSet.Contains(40001 * points[i][0] + points[j][1]) && pointSet.Contains(40001 * points[j][0] + points[i][1]))
                            result = Math.Min(result, Math.Abs(points[i][0] - points[j][0]) * Math.Abs(points[i][1] - points[j][1]));

            return result < int.MaxValue ? result : 0;
        }
    }
}
