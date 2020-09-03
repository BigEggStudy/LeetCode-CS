using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1418_DisplayTableOfFoodOrdersInARestaurant_Test
    {
        [TestMethod]
        public void DisplayTable_1()
        {
            var solution = new _1418_DisplayTableOfFoodOrdersInARestaurant();
            var result = solution.DisplayTable(new string[][] {
                new string[] { "David", "3", "Ceviche" },
                new string[] { "Corina", "10", "Beef Burrito" },
                new string[] { "David", "3", "Fried Chicken" },
                new string[] { "Carla", "5", "Water" },
                new string[] { "Carla", "5", "Ceviche" },
                new string[] { "Rous", "3", "Ceviche" },
            });
            AssertHelper.AssertList(new List<IList<string>> {
                new string[] { "Table", "Beef Burrito", "Ceviche", "Fried Chicken", "Water" },
                new string[] { "3", "0", "2", "1", "0" },
                new string[] { "5", "0", "1", "0", "1" },
                new string[] { "10", "1", "0", "0", "0" },
            }, result);
        }

        [TestMethod]
        public void DisplayTable_2()
        {
            var solution = new _1418_DisplayTableOfFoodOrdersInARestaurant();
            var result = solution.DisplayTable(new string[][] {
                new string[] { "James", "12", "Fried Chicken" },
                new string[] { "Ratesh", "12", "Fried Chicken" },
                new string[] { "Amadeus", "12", "Fried Chicken" },
                new string[] { "Adam", "1", "Canadian Waffles" },
                new string[] { "Brianna", "1", "Canadian Waffles" },
            });
            AssertHelper.AssertList(new List<IList<string>> {
                new string[] { "Table", "Canadian Waffles", "Fried Chicken" },
                new string[] { "1", "2", "0" },
                new string[] { "12", "0", "3" },
            }, result);
        }

        [TestMethod]
        public void DisplayTable_3()
        {
            var solution = new _1418_DisplayTableOfFoodOrdersInARestaurant();
            var result = solution.DisplayTable(new string[][] {
                new string[] { "Laura", "2", "Bean Burrito" },
                new string[] { "Jhon", "2", "Beef Burrito" },
                new string[] { "Melissa", "2", "Soda" },
            });
            AssertHelper.AssertList(new List<IList<string>> {
                new string[] { "Table", "Bean Burrito", "Beef Burrito", "Soda" },
                new string[] { "2", "1", "1", "1" },
            }, result);
        }

        [TestMethod]
        public void DisplayTable_4()
        {
            var solution = new _1418_DisplayTableOfFoodOrdersInARestaurant();
            var result = solution.DisplayTable(new string[][] {
                new string[] { "pKKgO", "1", "qgGxK" },
                new string[] { "ZgW", "3", "XfuBe" },
            });
            AssertHelper.AssertList(new List<IList<string>> {
                new string[] { "Table", "XfuBe", "qgGxK" },
                new string[] { "1", "0", "1" },
                new string[] { "3", "1", "0" },
            }, result);
        }
    }
}
