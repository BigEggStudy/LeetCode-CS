//-----------------------------------------------------------------------------
// Runtime: 212ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0904_FruitIntoBaskets
    {
        public int TotalFruit(int[] tree)
        {
            var b1 = -1;
            var b1Size = 0;
            var b2 = -1;
            var b2Size = 0;
            var max = 0;

            foreach (var treeType in tree)
            {
                if (b2 == -1)
                {
                    b2 = treeType;
                    b2Size = 1;
                }
                else if (b2 == treeType)
                {
                    b2Size++;
                }
                else if (b1 == treeType)
                {
                    b1 = b2;
                    b1Size += b2Size;
                    b2 = treeType;
                    b2Size = 1;
                }
                else
                {
                    b1 = b2;
                    b1Size = b2Size;
                    b2 = treeType;
                    b2Size = 1;
                }
                max = Math.Max(max, b1Size + b2Size);
            }
            return max;
        }
    }
}
