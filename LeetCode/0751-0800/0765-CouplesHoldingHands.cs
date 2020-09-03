//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0765_CouplesHoldingHands
    {
        public int MinSwapsCouples(int[] row)
        {
            int n = row.Length;
            int[] pos = new int[n];
            for (int i = 0; i < n; i++)
                pos[row[i]] = i;

            int count = 0;
            for (int i = 0; i < row.Length; i += 2)
            {
                int x = row[i];
                if (row[i + 1] == (x ^ 1)) continue;

                count++;
                Swap(row, pos, i + 1, pos[(x ^ 1)]);
            }
            return count;
        }

        private void Swap(int[] row, int[] pos, int x, int y)
        {
            int temp = row[x];
            pos[temp] = y;
            pos[row[y]] = x;
            row[x] = row[y];
            row[y] = temp;
        }
    }
}
