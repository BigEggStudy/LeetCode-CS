//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/submissions/detail/360501165/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0950_RevealCardsInIncreasingOrder
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            var index = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
                index.Enqueue(i);

            Array.Sort(deck);

            var results = new int[deck.Length];
            foreach (var card in deck)
            {
                results[index.Dequeue()] = card;
                if (index.Count > 0)
                    index.Enqueue(index.Dequeue());
            }

            return results;
        }
    }
}
