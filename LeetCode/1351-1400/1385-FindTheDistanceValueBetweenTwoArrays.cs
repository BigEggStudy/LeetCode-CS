//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.2 MB
// Link: https://leetcode.com/submissions/detail/329247369/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1385_FindTheDistanceValueBetweenTwoArrays
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            Array.Sort(arr2);

            var result = 0;
            foreach (var num in arr1)
            {
                var index1 = Array.BinarySearch(arr2, num - d);
                var index2 = Array.BinarySearch(arr2, num + d);

                if (index1 < 0) index1 = ~index1;
                if (index2 < 0) index2 = ~index2 - 1;
                if (index1 > index2) result++;
            }

            return result;
        }
    }
}
