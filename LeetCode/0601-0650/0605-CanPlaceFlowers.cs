//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 29.6 MB
// Link: https://leetcode.com/submissions/detail/359585096/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0605_CanPlaceFlowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i++] = 1;
                    count++;
                }

                if (count >= n) return true;
            }

            return count >= n;
        }
    }
}
