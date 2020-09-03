//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 32.6 MB
// Link: https://leetcode.com/submissions/detail/340992362/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1089_DuplicateZeros
    {
        public void DuplicateZeros(int[] arr)
        {
            var queue = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + queue.Count < arr.Length)
                {
                    queue.Enqueue(arr[i]);
                    if (arr[i] == 0)
                        queue.Enqueue(arr[i]);
                }

                arr[i] = queue.Dequeue();
            }
        }
    }
}
