//-----------------------------------------------------------------------------
// Runtime: 700ms
// Memory Usage: 47 MB
// Link: https://leetcode.com/submissions/detail/364031746/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1418_DisplayTableOfFoodOrdersInARestaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var foods = new HashSet<string>();
            var table = new Dictionary<int, Dictionary<string, int>>();

            foreach (var order in orders)
            {
                var tableNumber = Convert.ToInt32(order[1]);
                var food = order[2];
                foods.Add(food);

                if (!table.ContainsKey(tableNumber))
                    table.Add(tableNumber, new Dictionary<string, int>());

                var currentTable = table[tableNumber];
                if (currentTable.ContainsKey(food))
                    currentTable[food]++;
                else
                    currentTable.Add(food, 1);
            }

            var result = new List<IList<string>>();
            var firstRow = new List<string>() { "Table" };
            var sortedFoodItems = foods.OrderBy(x => x, StringComparer.Ordinal).ToArray();
            firstRow.AddRange(sortedFoodItems);
            result.Add(firstRow);

            var tableIndexs = table.Keys.OrderBy(x => x).ToArray();
            const string zeroString = "0";

            foreach (var tableNumber in tableIndexs)
            {
                var currentTable = table[tableNumber];

                var tableRow = new List<string>();
                tableRow.Add(tableNumber.ToString());
                foreach (var foodItem in sortedFoodItems)
                {
                    if (currentTable.ContainsKey(foodItem))
                        tableRow.Add(currentTable[foodItem].ToString());
                    else
                        tableRow.Add(zeroString);
                }

                result.Add(tableRow);
            }

            return result;
        }
    }
}
