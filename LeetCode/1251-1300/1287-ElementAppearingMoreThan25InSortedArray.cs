//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 27.2 MB
// Link: https://leetcode.com/submissions/detail/336986817/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1287_ElementAppearingMoreThan25InSortedArray
    {
        public int FindSpecialInteger(int[] arr)
        {
            var len = arr.Length / 4;

            var count = 1;
            var current = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == current)
                {
                    count++;
                    if (count > len)
                        return current;
                }
                else
                {
                    count = 0;
                    current = arr[i];
                }
            }

            return current;
        }
    }
}
