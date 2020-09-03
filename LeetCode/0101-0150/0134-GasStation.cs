//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/379516843/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0134_GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int totalGas = 0, currentTank = 0;
            var startIndex = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                totalGas += gas[i] - cost[i];
                currentTank += gas[i] - cost[i];
                if (currentTank < 0)
                {
                    startIndex = i + 1;
                    currentTank = 0;
                }
            }
            return totalGas >= 0 ? startIndex : -1;
        }
    }
}
