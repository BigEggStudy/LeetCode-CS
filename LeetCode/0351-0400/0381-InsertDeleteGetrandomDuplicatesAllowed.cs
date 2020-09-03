//-----------------------------------------------------------------------------
// Runtime: 192ms
// Memory Usage: 43.3 MB
// Link: https://leetcode.com/submissions/detail/368921727/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0381_InsertDeleteGetrandomDuplicatesAllowed
    {
        private readonly Random random;
        private readonly IDictionary<int, ISet<int>> locations;
        private readonly IList<int> nums;

        /** Initialize your data structure here. */
        public _0381_InsertDeleteGetrandomDuplicatesAllowed()
        {
            random = new Random();
            locations = new Dictionary<int, ISet<int>>();
            nums = new List<int>();
        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (!locations.ContainsKey(val))
                locations[val] = new HashSet<int>();

            locations[val].Add(nums.Count);
            nums.Add(val);
            return locations[val].Count == 1;
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            if (!locations.ContainsKey(val)) return false;

            var id = locations[val].First();
            locations[val].Remove(id);

            var num = nums[nums.Count - 1];
            nums[id] = num;
            locations[num].Add(id);
            locations[num].Remove(nums.Count - 1);
            nums.RemoveAt(nums.Count - 1);

            if (locations[val].Count == 0) locations.Remove(val);

            return true;
        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            var id = random.Next(nums.Count);
            return nums[id];
        }
    }

    /**
     * Your RandomizedCollection object will be instantiated and called as such:
     * RandomizedCollection obj = new RandomizedCollection();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
