//-----------------------------------------------------------------------------
// Runtime: 296ms
// Memory Usage: 41.8 MB
// Link: https://leetcode.com/submissions/detail/344732795/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0599_MinimumIndexSumOfTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            if (list1.Length > list2.Length) return FindRestaurant(list2, list1);

            var map = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
                map[list1[i]] = i;

            var result = new List<string>();
            var sum = int.MaxValue;
            for (int i = 0; i < list2.Length; i++)
            {
                if (!map.ContainsKey(list2[i]))
                    continue;

                var cur = map[list2[i]] + i;
                if (cur < sum)
                {
                    sum = cur;
                    result.Clear();
                    result.Add(list2[i]);
                }
                else if (cur == sum)
                    result.Add(list2[i]);
            }

            return result.ToArray();
        }
    }
}
