//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 32.4 MB
// Link: https://leetcode.com/submissions/detail/360356852/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1282_GroupThePeopleGivenTheGroupSizeTheyBelongTo
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var counts = new Dictionary<int, IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!counts.ContainsKey(groupSizes[i]))
                    counts.Add(groupSizes[i], new List<int>());
                counts[groupSizes[i]].Add(i);
            }

            var results = new List<IList<int>>();
            foreach (var pair in counts)
            {
                var result = new List<int>(pair.Key);
                foreach (var item in pair.Value)
                {
                    result.Add(item);
                    if (result.Count == pair.Key)
                    {
                        results.Add(result);
                        result = new List<int>(pair.Key);
                    }
                }
            }

            return results;
        }
    }
}
