//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0315_CountOfSmallerNumbersAfterSelf
    {
        public IList<int> CountSmaller(int[] nums)
        {
            if (nums.Length == 0) return nums;

            int[] counts = new int[nums.Length];
            Node root = new Node(nums[nums.Length - 1]);

            for (int i = nums.Length - 2; i >= 0; i--)
                counts[i] = Insert(root, nums[i]);

            return counts;
        }

        private int Insert(Node root, int value)
        {
            if (value < root.Value)
            {
                root.LessCount++;
                if (root.Left == null)
                {
                    root.Left = new Node(value);
                    return 0;
                }
                return Insert(root.Left, value);
            }
            else if (root.Value < value)
            {
                if (root.Right == null)
                {
                    root.Right = new Node(value);
                    return root.EqualCount + root.LessCount;
                }
                return root.EqualCount + root.LessCount + Insert(root.Right, value);
            }
            else
            {
                root.EqualCount++;
                return root.LessCount;
            }
        }

        public class Node
        {
            public int Value;
            public int EqualCount = 1;
            public int LessCount = 0;

            public Node Left;
            public Node Right;

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}
