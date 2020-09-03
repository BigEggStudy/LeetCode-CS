//-----------------------------------------------------------------------------
// Runtime: 144ms
// Memory Usage: 40.5 MB
// Link: https://leetcode.com/submissions/detail/352711483/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0380_InsertDeleteGetRandom
    {
        private readonly Random random = new Random();
        private readonly IDictionary<int, int> locations;
        private readonly IList<int> nums;

        /** Initialize your data structure here. */
        public _0380_InsertDeleteGetRandom()
        {
            locations = new Dictionary<int, int>();
            nums = new List<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (locations.ContainsKey(val)) return false;
            locations.Add(val, nums.Count);
            nums.Add(val);
            return true;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (!locations.ContainsKey(val)) return false;
            if (locations[val] != nums.Count - 1)
            {
                nums[locations[val]] = nums[nums.Count - 1];
                locations[nums[nums.Count - 1]] = locations[val];
            }

            locations.Remove(val);
            nums.RemoveAt(nums.Count - 1);
            return true;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            var index = random.Next(nums.Count);
            return nums[index];
        }
    }
}
