//-----------------------------------------------------------------------------
// Runtime: 296ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _090_Subsets2
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var results = new List<IList<int>>() { new List<int>() };
            if (nums.Length == 0) return results;

            Array.Sort(nums);

            results.Add(new List<int>() { nums[0] });
            IList<IList<int>> lastAdded = new List<IList<int>>() { new List<int>() { nums[0] } };

            for (var i = 1; i < nums.Length; i++)
            {
                var result = new List<IList<int>>();
                if (nums[i] == nums[i - 1])
                {
                    foreach (var item in lastAdded)
                    {
                        var newItem = new List<int>(item);
                        newItem.Add(nums[i]);
                        result.Add(newItem);
                    }
                }
                else
                {
                    foreach (var item in results)
                    {
                        var newItem = new List<int>(item);
                        newItem.Add(nums[i]);
                        result.Add(newItem);
                    }
                }
                results.AddRange(result);
                lastAdded = result;
            }

            return results;
        }
    }
}
