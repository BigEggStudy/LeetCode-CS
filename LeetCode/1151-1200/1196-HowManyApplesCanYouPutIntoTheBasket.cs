//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/330153537/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1196_HowManyApplesCanYouPutIntoTheBasket
    {
        public int MaxNumberOfApples(int[] arr)
        {
            Array.Sort(arr);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (sum > 5000) return i;
            }

            return arr.Length;
        }
    }
}
