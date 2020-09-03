//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0465_OptimalAccountBalancing
    {
        public int MinTransfers(int[][] transactions)
        {
            var balanceMap = new Dictionary<int, int>();
            foreach (var transaction in transactions)
            {
                if (balanceMap.ContainsKey(transaction[0]))
                    balanceMap[transaction[0]] -= transaction[2];
                else
                    balanceMap[transaction[0]] = -transaction[2];

                if (balanceMap.ContainsKey(transaction[1]))
                    balanceMap[transaction[1]] += transaction[2];
                else
                    balanceMap[transaction[1]] = transaction[2];
            }

            var balances = balanceMap.Values.Where(x => x != 0).OrderBy(x => x).ToList();
            int count = 0;
            for (int i = 2; i <= balances.Count; i++)
            {
                while (HasSubsetSum(balances, 0, i))
                {
                    count += i - 1;
                    balances = balances.Where(x => x != int.MinValue).OrderBy(x => x).ToList();
                }
            }

            return count;
        }

        private bool HasSubsetSum(List<int> list, int sum, int num)
        {
            if (num == 0) return sum == 0;
            if (num == 1)
            {
                var index = list.BinarySearch(sum);
                if (index >= 0)
                {
                    list[index] = int.MinValue;
                    return true;
                }
                else
                    return false;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0) continue;
                var value = list[i];
                list[i] = int.MinValue;
                if (HasSubsetSum(list, sum - value, num - 1)) return true;
                list[i] = value;
            }
            return false;
        }
    }
}
