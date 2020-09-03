//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 30.3 MB
// Link: https://leetcode.com/submissions/detail/330680788/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1122_RelativeSortArray
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var counts = new Dictionary<int, int>();
            foreach (var num in arr1)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            var index = 0;
            foreach (var num in arr2)
            {
                var count = counts[num];
                while (count > 0)
                {
                    arr1[index++] = num;
                    count--;
                }
                counts.Remove(num);
            }

            foreach (var key in counts.Keys.OrderBy(num => num))
            {
                var count = counts[key];
                while (count > 0)
                {
                    arr1[index++] = key;
                    count--;
                }
            }

            return arr1;
        }
    }
}
