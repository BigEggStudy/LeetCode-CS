//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.7 MB
// Link: https://leetcode.com/submissions/detail/378077559/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _042_TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int n = height.Length;
            if (n == 0) { return 0; }

            int maxLeftHeight = height[0], maxRightHeight = height[n - 1];
            int result = 0, tempResultLeft = 0, tempResultRight = 0;

            for (int i = 0; i < n; i++)
            {
                if (maxLeftHeight > height[i])
                {
                    tempResultLeft += maxLeftHeight - height[i];
                }
                else
                {
                    maxLeftHeight = height[i];
                    result += tempResultLeft;
                    tempResultLeft = 0;
                }

                if (maxRightHeight > height[n - i - 1])
                {
                    tempResultRight += maxRightHeight - height[n - i - 1];
                }
                else if (maxRightHeight < height[n - i - 1])
                {
                    maxRightHeight = height[n - i - 1];
                    result += tempResultRight;
                    tempResultRight = 0;
                }
            }

            return result;
        }
    }
}
