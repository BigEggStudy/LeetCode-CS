//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/335019740/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0496_NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0) return nums1;

            var nextElements = new Dictionary<int, int>();
            var stack = new Stack<int>();
            stack.Push(nums2[0]);
            for (int i = 1; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && nums2[i] > stack.Peek())
                {
                    var num = stack.Pop();
                    nextElements.Add(num, nums2[i]);
                }
                stack.Push(nums2[i]);
            }
            while (stack.Count > 0)
            {
                var num = stack.Pop();
                nextElements.Add(num, -1);
            }

            for (int i = 0; i < nums1.Length; i++)
                nums1[i] = nextElements[nums1[i]];

            return nums1;
        }
    }
}
