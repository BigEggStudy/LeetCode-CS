//-----------------------------------------------------------------------------
// Runtime: 624ms
// Memory Usage: 47.5 MB
// Link: https://leetcode.com/submissions/detail/368937157/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1396_DesignUndergroundSystem
    {
        private IDictionary<string, (int sum, int times)> completes;
        private IDictionary<int, (string start, int startTime)> checkIn;

        public _1396_DesignUndergroundSystem()
        {
            completes = new Dictionary<string, (int sum, int times)>();
            checkIn = new Dictionary<int, (string start, int startTime)>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            checkIn.Add(id, (stationName, t));
        }

        public void CheckOut(int id, string stationName, int t)
        {
            (string start, int startTime) = checkIn[id];
            checkIn.Remove(id);

            var route = $"{start}_{stationName}";
            if (!completes.ContainsKey(route))
                completes[route] = (t - startTime, 1);
            else
            {
                (int sum, int times) = completes[route];
                completes[route] = (sum + (t - startTime), times + 1);
            }
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var route = $"{startStation}_{endStation}";
            (int sum, int times) = completes[route];
            return 1.0 * sum / times;
        }
    }

    /**
     * Your UndergroundSystem object will be instantiated and called as such:
     * UndergroundSystem obj = new UndergroundSystem();
     * obj.CheckIn(id,stationName,t);
     * obj.CheckOut(id,stationName,t);
     * double param_3 = obj.GetAverageTime(startStation,endStation);
     */
}
