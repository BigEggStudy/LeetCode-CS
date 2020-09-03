//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/335637285/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0800_SimilarRGBColor
    {
        public string SimilarRGB(string color)
        {
            return $"#{Compute(color.Substring(1, 2))}{Compute(color.Substring(3, 2))}{Compute(color.Substring(5, 2))}";
        }

        private string Compute(string channel)
        {
            var num = Convert.ToInt32(channel, 16);
            var newValue = num / 17 + (num % 17 > 8 ? 1 : 0);
            return (newValue * 17).ToString("X2").ToLower();
        }
    }
}
