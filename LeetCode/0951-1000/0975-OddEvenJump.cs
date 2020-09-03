//-----------------------------------------------------------------------------
// Runtime: 204ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0975_OddEvenJump
    {
        public int OddEvenJumps(int[] A)
        {
            var length = A.Length;
            var oddPosibility = new bool[length];
            var evenPosibility = new bool[length];
            oddPosibility[length - 1] = true;
            evenPosibility[length - 1] = true;

            var map = new SortedList<int, int>
            {
                { A[length - 1], length - 1 }
            };
            var result = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                var existed = map.TryGetValue(A[i], out int index);
                map[A[i]] = i;

                if (existed)
                {
                    oddPosibility[i] = evenPosibility[index];
                    evenPosibility[i] = oddPosibility[index];
                }
                else
                {
                    index = map.IndexOfKey(A[i]);
                    if (index != map.Count - 1)
                        oddPosibility[i] = evenPosibility[map.Values[index + 1]];
                    if (index != 0)
                        evenPosibility[i] = oddPosibility[map.Values[index - 1]];
                }

                if (oddPosibility[i])
                    result++;
            }

            return result;
        }
    }
}
