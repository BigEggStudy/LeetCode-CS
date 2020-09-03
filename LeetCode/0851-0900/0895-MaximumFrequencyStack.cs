//-----------------------------------------------------------------------------
// Runtime: 372ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0895_MaximumFrequencyStack
    {
        private readonly IDictionary<int, int> frequencyMap;
        private readonly IDictionary<int, Stack<int>> frequencyValues;
        private int maxFrequency;

        public _0895_MaximumFrequencyStack()
        {
            frequencyMap = new Dictionary<int, int>();
            frequencyValues = new Dictionary<int, Stack<int>>();
            maxFrequency = 0;
        }

        public void Push(int x)
        {
            if (!frequencyMap.ContainsKey(x))
                frequencyMap[x] = 0;
            frequencyMap[x] += 1;

            if (frequencyMap[x] > maxFrequency)
                maxFrequency = frequencyMap[x];

            if (!frequencyValues.ContainsKey(frequencyMap[x]))
                frequencyValues[frequencyMap[x]] = new Stack<int>();
            frequencyValues[frequencyMap[x]].Push(x);
        }

        public int Pop()
        {
            var result = frequencyValues[maxFrequency].Pop();

            frequencyMap[result] -= 1;
            if (frequencyValues[maxFrequency].Count == 0)
                maxFrequency--;

            return result;
        }
    }
}
