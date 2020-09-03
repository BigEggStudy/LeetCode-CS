//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 32.8 MB
// Link: https://leetcode.com/submissions/detail/358333842/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0624_MaximumDistanceInArrays
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            int result = 0, min = arrays[0][0], max = arrays[0][arrays[0].Count - 1];
            for (int i = 1; i < arrays.Count; i++)
            {
                result = Math.Max(result, Math.Abs(arrays[i][arrays[i].Count - 1] - min));
                result = Math.Max(result, Math.Abs(max - arrays[i][0]));

                min = Math.Min(min, arrays[i][0]);
                max = Math.Max(max, arrays[i][arrays[i].Count - 1]);
            }
            return result;
        }
    }
}
