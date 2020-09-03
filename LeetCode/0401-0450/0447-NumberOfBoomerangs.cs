//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 46.2 MB
// Link: https://leetcode.com/submissions/detail/344205280/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0447_NumberOfBoomerangs
    {
        public int NumberOfBoomerangs(int[][] points)
        {
            var count = 0;

            foreach (var point1 in points)
            {
                var distMap = new Dictionary<int, int>();
                foreach (var point2 in points)
                {
                    int distSq = (int)Math.Pow(point1[0] - point2[0], 2) + (int)Math.Pow(point1[1] - point2[1], 2);
                    if (!distMap.ContainsKey(distSq))
                        distMap.Add(distSq, 1);
                    else
                        count += distMap[distSq]++;
                }
            }

            return count * 2;
        }
    }
}
