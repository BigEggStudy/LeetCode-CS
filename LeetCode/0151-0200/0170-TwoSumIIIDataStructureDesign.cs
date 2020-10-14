//-----------------------------------------------------------------------------
// Runtime: 216ms
// Memory Usage: 42.6 MB
// Link: https://leetcode.com/submissions/detail/406709543/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0170_TwoSumIIIDataStructureDesign
    {
        private readonly IDictionary<int, int> counts;


        /** Initialize your data structure here. */
        public _0170_TwoSumIIIDataStructureDesign()
        {
            counts = new Dictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (counts.ContainsKey(number))
                counts[number]++;
            else
                counts[number] = 1;
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach (var key in counts.Keys)
            {
                var num = value - key;
                if (num != key)
                {
                    if (counts.ContainsKey(num)) return true;
                }
                else
                {
                    if (counts[key] > 1) return true;
                }
            }

            return false;
        }
    }

    /**
     * Your TwoSum object will be instantiated and called as such:
     * TwoSum obj = new TwoSum();
     * obj.Add(number);
     * bool param_2 = obj.Find(value);
     */
}
