//-----------------------------------------------------------------------------
// Runtime: 136ms
// Memory Usage: 28.7 MB
// Link: https://leetcode.com/submissions/detail/379531435/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0127_WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var map = new HashSet<string>(wordList);
            if (!map.Contains(endWord))
                return 0;
            var wordLength = beginWord.Length;

            var used1 = new Dictionary<string, int>();
            var used2 = new Dictionary<string, int>();
            used1[beginWord] = 1;
            used2[endWord] = 1;

            var queue1 = new Queue<string>();
            var queue2 = new Queue<string>();
            queue1.Enqueue(beginWord);
            queue2.Enqueue(endWord);

            while (queue1.Count != 0 && queue2.Count != 0)
            {
                var str1 = queue1.Dequeue();
                var str2 = queue2.Dequeue();

                StringBuilder sb1 = new StringBuilder(str1);
                StringBuilder sb2 = new StringBuilder(str2);

                for (char i = 'a'; i <= 'z'; i++)
                {
                    for (int j = 0; j < wordLength; j++)
                    {
                        var temp = sb1[j];
                        sb1[j] = i;
                        var nextWord = sb1.ToString();
                        if (map.Contains(nextWord) && !used1.ContainsKey(nextWord))
                        {
                            if (used2.ContainsKey(nextWord))
                            {
                                return used2[nextWord] + used1[str1];
                            }
                            else
                            {
                                used1[nextWord] = used1[str1] + 1;
                            }
                            queue1.Enqueue(nextWord);
                        }
                        sb1[j] = temp;
                    }
                    for (int j = 0; j < wordLength; j++)
                    {
                        var temp = sb2[j];
                        sb2[j] = i;
                        var previousWord = sb2.ToString();
                        if (map.Contains(previousWord) && !used2.ContainsKey(previousWord))
                        {
                            if (used1.ContainsKey(previousWord))
                            {
                                return used1[previousWord] + used2[str2];
                            }
                            else
                            {
                                used2[previousWord] = used2[str2] + 1;
                            }
                            queue2.Enqueue(previousWord);
                        }
                        sb2[j] = temp;
                    }
                }
            }

            return 0;
        }
    }
}
