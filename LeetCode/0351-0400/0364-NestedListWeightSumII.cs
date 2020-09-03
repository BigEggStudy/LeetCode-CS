//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 19.7 MB
// Link: https://leetcode.com/submissions/detail/369931182/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /**
     * // This is the interface that allows for creating nested lists.
     * // You should not implement it, or speculate about its implementation
     * interface NestedInteger {
     *
     *     // Constructor initializes an empty nested list.
     *     public NestedInteger();
     *
     *     // Constructor initializes a single integer.
     *     public NestedInteger(int value);
     *
     *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
     *     bool IsInteger();
     *
     *     // @return the single integer that this NestedInteger holds, if it holds a single integer
     *     // Return null if this NestedInteger holds a nested list
     *     int GetInteger();
     *
     *     // Set this NestedInteger to hold a single integer.
     *     public void SetInteger(int value);
     *
     *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
     *     public void Add(NestedInteger ni);
     *
     *     // @return the nested list that this NestedInteger holds, if it holds a nested list
     *     // Return null if this NestedInteger holds a single integer
     *     IList<NestedInteger> GetList();
     * }
     */
    public class _0364_NestedListWeightSumII
    {
        public int DepthSumInverse(IList<NestedInteger> nestedList)
        {
            if (nestedList.Count == 0) return 0;

            var levels = new Dictionary<int, IList<int>>();
            FlatList(nestedList, levels, 1);
            if (levels.Count == 0) return 0;

            var max = levels.Keys.Max();
            var sum = 0;
            foreach (var key in levels.Keys)
                sum += levels[key].Sum() * (max - key + 1);

            return sum;
        }

        private void FlatList(IList<NestedInteger> nestedList, IDictionary<int, IList<int>> levels, int level)
        {
            foreach (var ni in nestedList)
            {
                if (ni.IsInteger())
                {
                    if (levels.ContainsKey(level))
                        levels[level].Add(ni.GetInteger());
                    else
                        levels[level] = new List<int>() { ni.GetInteger() };
                }
                else
                    FlatList(ni.GetList(), levels, level + 1);
            }
        }

        public class NestedInteger
        {
            private int? number;
            private IList<NestedInteger> list;


            // Constructor initializes an empty nested list.
            public NestedInteger()
            {
                number = null;
                list = new List<NestedInteger>();
            }

            // Constructor initializes a single integer.
            public NestedInteger(int value)
            {
                number = value;
            }


            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            public bool IsInteger()
            {
                return number.HasValue;
            }

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            public int GetInteger()
            {
                return number.Value;
            }

            // Set this NestedInteger to hold a single integer.
            public void SetInteger(int value)
            {
                number = value;
            }

            // Set this NestedInteger to hold a nested list and adds a nested integer to it.
            public void Add(NestedInteger ni)
            {
                number = null;
                if (list == null)
                    list = new List<NestedInteger>() { ni };
                else
                    list.Add(ni);
            }

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            public IList<NestedInteger> GetList()
            {
                return list;
            }
        }
    }
}
