//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 35.6 MB
// Link: https://leetcode.com/submissions/detail/327374516/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1299_ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            var max = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                var temp = arr[i];
                arr[i] = max;
                max = Math.Max(temp, max);
            }

            return arr;
        }
    }
}
