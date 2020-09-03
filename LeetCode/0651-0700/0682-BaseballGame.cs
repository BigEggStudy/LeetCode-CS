//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/335007706/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0682_BaseballGame
    {
        public int CalPoints(string[] ops)
        {
            var roundPoints = new int[ops.Length];
            var index = 0;

            foreach (var op in ops)
            {
                if (op == "C")
                    index--;
                else if (op == "D")
                {
                    roundPoints[index] = roundPoints[index - 1] * 2;
                    index++;
                }
                else if (op == "+")
                {
                    roundPoints[index] = roundPoints[index - 1] + roundPoints[index - 2];
                    index++;
                }
                else
                    roundPoints[index++] = int.Parse(op);
            }

            var sum = 0;
            for (int i = 0; i < index; i++)
                sum += roundPoints[i];

            return sum;
        }
    }
}
