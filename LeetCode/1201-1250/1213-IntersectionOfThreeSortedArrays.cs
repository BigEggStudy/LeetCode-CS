//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 32.4 MB
// Link: https://leetcode.com/submissions/detail/327380202/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1213_IntersectionOfThreeSortedArrays
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0;
            int length = Math.Min(Math.Min(arr1.Length, arr2.Length), arr3.Length);

            var result = new List<int>();
            for (int k = 0; k < length; k++)
            {
                while (i < length && arr1[i] < arr3[k]) i++;
                while (j < length && arr2[j] < arr3[k]) j++;

                if (i < length && j < length && arr1[i] == arr2[j] && arr1[i] == arr3[k])
                    result.Add(arr1[i]);
            }

            return result;
        }
    }
}
