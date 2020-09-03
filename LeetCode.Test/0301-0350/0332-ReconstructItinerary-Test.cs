using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0332_ReconstructItinerary_Test
    {
        [TestMethod]
        public void FindItineraryTest_1()
        {
            var solution = new _0332_ReconstructItinerary();
            var result = solution.FindItinerary(new List<IList<string>>()
            {
                new List<string>() { "MUC", "LHR" },
                new List<string>() { "JFK", "MUC" },
                new List<string>() { "SFO", "SJC" },
                new List<string>() { "LHR", "SFO" },
            });
            AssertHelper.AssertList(new string[] { "JFK", "MUC", "LHR", "SFO", "SJC" }, result);
        }

        [TestMethod]
        public void FindItineraryTest_2()
        {
            var solution = new _0332_ReconstructItinerary();
            var result = solution.FindItinerary(new List<IList<string>>()
            {
                new List<string>() { "JFK", "SFO" },
                new List<string>() { "JFK", "ATL" },
                new List<string>() { "SFO", "ATL" },
                new List<string>() { "ATL", "JFK" },
                new List<string>() { "ATL", "SFO" },
            });
            AssertHelper.AssertList(new string[] { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" }, result);
        }

        [TestMethod]
        public void FindItineraryTest_3()
        {
            var solution = new _0332_ReconstructItinerary();
            var result = solution.FindItinerary(new List<IList<string>>()
            {
                new List<string>() { "EZE","AXA" },
                new List<string>() { "TIA","ANU" },
                new List<string>() { "ANU","JFK" },
                new List<string>() { "JFK","ANU" },
                new List<string>() { "ANU","EZE" },
                new List<string>() { "TIA","ANU" },
                new List<string>() { "AXA","TIA" },
                new List<string>() { "TIA","JFK" },
                new List<string>() { "ANU","TIA" },
                new List<string>() { "JFK","TIA" },
            });
            AssertHelper.AssertList(new string[] { "JFK", "ANU", "EZE", "AXA", "TIA", "ANU", "JFK", "TIA", "ANU", "TIA", "JFK" }, result);
        }
    }
}
