//-----------------------------------------------------------------------------
// Runtime: 60ms
// Memory Usage: 19.5 MB
// Link: https://leetcode.com/submissions/detail/328300270/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

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
    public class _0339_NestedListWeightSum
    {
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            var sum = 0;
            foreach (var item in nestedList)
            {
                sum += SumNestedInteger(item, 1);
            }

            return sum;
        }

        private int SumNestedInteger(NestedInteger ni, int depth)
        {
            if (ni.IsInteger())
                return ni.GetInteger().Value * depth;
            else
            {
                var sum = 0;
                foreach (var item in ni.GetList())
                    sum += SumNestedInteger(item, depth + 1);

                return sum;
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
            public int? GetInteger()
            {
                return number;
            }

            // Set this NestedInteger to hold a single integer.
            public void SetInteger(int value)
            {
                number = value;
                list = null;
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
