//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0843_GuesstheWord
    {
        /**
         * // This is the Master's API interface.
         * // You should not implement it, or speculate about its implementation
         * class Master {
         *     public int Guess(string word);
         * }
         */
        public void FindSecretWord(string[] wordlist, Master master)
        {
            var random = new Random();
            var wordlistHashSet = new HashSet<string>(wordlist);

            for (int i = 0; i < 10; i++)
            {
                var word = wordlistHashSet.ElementAt(random.Next(wordlistHashSet.Count));
                var result = master.Guess(word);
                if (result == word.Length) return;

                wordlistHashSet.RemoveWhere(anotherWord => MatchCount(word, anotherWord) != result);
                wordlistHashSet.Remove(word);
            }
        }

        public int MatchCount(string word1, string word2)
        {
            var count = 0;
            for (int i = 0; i < word1.Length; i++)
                if (word1[i] == word2[i])
                    count++;

            return count;
        }
    }

    public class Master
    {
        private readonly string secret;
        private readonly HashSet<string> wordlist;

        public Master(string secret, string[] wordlist)
        {
            this.secret = secret;
            this.wordlist = new HashSet<string>(wordlist);

            GuessCount = 0;
        }

        public int GuessCount { get; set; }

        public int Guess(string word)
        {
            GuessCount++;
            if (this.secret.Length != word.Length) { return -1; }
            if (!wordlist.Contains(word)) { return -1; }

            var count = 0;
            for (int i = 0; i < word.Length; i++)
                if (word[i] == secret[i])
                    count++;

            return count;
        }
    }
}
