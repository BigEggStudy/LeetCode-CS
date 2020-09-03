//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/368554471/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1518_WaterBottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            var result = 0;
            var rest = 0;
            while (numBottles > 0)
            {
                result += numBottles;
                var temp = (numBottles + rest) % numExchange;
                numBottles = (numBottles + rest) / numExchange;
                rest = temp;
            }

            return result;
        }
    }
}
