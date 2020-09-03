//-----------------------------------------------------------------------------
// Runtime: 920ms
// Memory Usage: 105.1 MB
// Link: https://leetcode.com/submissions/detail/257928934/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0981_TimeBasedKeyValueStore
    {
        private readonly IDictionary<string, SortedList<int, string>> map;

        /** Initialize your data structure here. */
        public _0981_TimeBasedKeyValueStore()
        {
            map = new Dictionary<string, SortedList<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!map.ContainsKey(key))
                map.Add(key, new SortedList<int, string>());

            map[key].Add(timestamp, value);
        }

        public string Get(string key, int timestamp)
        {
            if (!map.ContainsKey(key)) return string.Empty;

            var list = map[key];
            for (var i = list.Count - 1; i >= 0; i--)
                if (list.Keys[i] <= timestamp)
                    return list.Values[i];

            return string.Empty;
        }
    }


    /**
     * Your TimeMap object will be instantiated and called as such:
     * TimeMap obj = new TimeMap();
     * obj.Set(key,value,timestamp);
     * string param_2 = obj.Get(key,timestamp);
     */
}
