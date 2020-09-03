//-----------------------------------------------------------------------------
// Runtime: 220ms
// Memory Usage: 29.6 MB
// Link: https://leetcode.com/submissions/detail/344211899/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1243_ArrayTransformation
    {
        public IList<int> TransformArray(int[] arr)
        {
            if (arr.Length <= 2) return arr;

            var changed = true;
            while (changed)
            {
                changed = false;

                int prev = arr[0];

                for (int i = 1; i < arr.Length - 1; i++)
                {
                    int curr = arr[i], next = arr[i + 1];
                    if (prev < curr && curr > next)
                    {
                        arr[i]--;
                        changed = true;
                    }
                    if (prev > curr && curr < next)
                    {
                        arr[i]++;
                        changed = true;
                    }

                    prev = curr;
                }
            }

            return arr;
        }
    }
}
