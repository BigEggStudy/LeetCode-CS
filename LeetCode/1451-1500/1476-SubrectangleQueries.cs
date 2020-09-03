//-----------------------------------------------------------------------------
// Runtime: 180ms
// Memory Usage: 40.4 MB
// Link: https://leetcode.com/submissions/detail/360342817/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1476_SubrectangleQueries
    {
        private int[][] rectangle;
        private IList<(int row1, int col1, int row2, int col2, int value)> updates;

        public _1476_SubrectangleQueries(int[][] rectangle)
        {
            this.rectangle = rectangle;
            this.updates = new List<(int row1, int col1, int row2, int col2, int newValue)>();
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            updates.Add((row1, col1, row2, col2, newValue));
        }

        public int GetValue(int row, int col)
        {
            for (int i = updates.Count - 1; i >= 0; i--)
            {
                var update = updates[i];
                if (update.row1 <= row && update.col1 <= col && row <= update.row2 && col <= update.col2)
                    return update.value;
            }

            return rectangle[row][col];
        }
    }

    /**
     * Your SubrectangleQueries object will be instantiated and called as such:
     * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
     * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
     * int param_2 = obj.GetValue(row,col);
     */
}
