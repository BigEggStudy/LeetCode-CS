//-----------------------------------------------------------------------------
// Runtime: 104
// Memory Usage: 27.3 MB
// Link: https://leetcode.com/submissions/detail/372498118/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0393_UTF8Validation
    {
        public bool ValidUtf8(int[] data)
        {
            int numberOfBytesToProcess = 0;

            int mask1 = 1 << 7;
            int mask2 = 1 << 6;

            foreach (int num in data)
            {
                if (numberOfBytesToProcess == 0)
                {
                    int mask = mask1;
                    while ((mask & num) != 0)
                    {
                        numberOfBytesToProcess++;
                        mask >>= 1;
                    }

                    if (numberOfBytesToProcess == 0) continue;
                    if (numberOfBytesToProcess > 4 || numberOfBytesToProcess == 1) return false;
                }
                else
                {
                    if ((num & mask1) == 0 || (mask2 & num) == 1)
                        return false;
                }

                numberOfBytesToProcess -= 1;
            }

            return numberOfBytesToProcess == 0;
        }
    }
}
