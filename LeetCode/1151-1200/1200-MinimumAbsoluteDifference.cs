//-----------------------------------------------------------------------------
// Runtime: 328ms
// Memory Usage: 42.5 MB
// Link: https://leetcode.com/submissions/detail/330738084/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1200_MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);

            var minDiff = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
                minDiff = Math.Min(minDiff, Math.Abs(arr[i + 1] - arr[i]));

            var result = new List<IList<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i + 1] - arr[i]) == minDiff)
                    result.Add(new List<int> { arr[i], arr[i + 1] });
            }

            return result;
        }
    }
}
