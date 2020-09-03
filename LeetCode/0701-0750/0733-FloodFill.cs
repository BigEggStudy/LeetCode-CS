//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 32.9 MB
// Link: https://leetcode.com/submissions/detail/338156600/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0733_FloodFill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var oldColor = image[sr][sc];
            if (oldColor == newColor) return image;

            var rows = image.Length;
            var cols = image[0].Length;
            var queue = new Queue<(int row, int col)>();
            queue.Enqueue((sr, sc));
            while (queue.Count > 0)
            {
                (int row, int col) = queue.Dequeue();
                image[row][col] = newColor;

                if (row > 0 && image[row - 1][col] == oldColor) queue.Enqueue((row - 1, col));
                if (row < rows - 1 && image[row + 1][col] == oldColor) queue.Enqueue((row + 1, col));
                if (col > 0 && image[row][col - 1] == oldColor) queue.Enqueue((row, col - 1));
                if (col < cols - 1 && image[row][col + 1] == oldColor) queue.Enqueue((row, col + 1));
            }

            return image;
        }
    }
}
