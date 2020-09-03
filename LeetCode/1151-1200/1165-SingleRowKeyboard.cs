//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 23.1 MB
// Link: https://leetcode.com/submissions/detail/326440843/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1165_SingleRowKeyboard
    {
        public int CalculateTime(string keyboard, string word)
        {
            var keyMapping = new Dictionary<char, int>();
            for (int i = 0; i < keyboard.Length; i++)
                keyMapping.Add(keyboard[i], i);

            var current = 0;
            var result = 0;
            foreach (var ch in word)
            {
                result += Math.Abs(current - keyMapping[ch]);
                current = keyMapping[ch];
            }

            return result;
        }
    }
}
