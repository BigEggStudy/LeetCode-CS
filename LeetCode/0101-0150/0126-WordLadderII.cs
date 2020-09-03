//-----------------------------------------------------------------------------
// Runtime: 332ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0126_WordLadderII
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var map = new HashSet<string>(wordList);
            if (!map.Contains(endWord))
                return new List<IList<string>>();

            var graph = new Dictionary<string, HashSet<string>>();
            if (!BuildGraph(beginWord, endWord, map, graph))
                return new List<IList<string>>();

            var answer = new List<IList<string>>();
            FindLadders(beginWord, endWord, graph, answer, new List<string>() { beginWord });

            return answer;
        }

        private void FindLadders(string beginWord, string endWord, IDictionary<string, HashSet<string>> graph, List<IList<string>> answer, List<string> solution)
        {
            if (beginWord == endWord)
            {
                answer.Add(new List<string>(solution));
                return;
            }

            if (!graph.ContainsKey(beginWord)) return;

            foreach (var word in graph[beginWord])
            {
                solution.Add(word);
                FindLadders(word, endWord, graph, answer, solution);
                solution.RemoveAt(solution.Count - 1);
            }
        }

        private bool BuildGraph(string beginWord, string endWord, HashSet<string> wordList, IDictionary<string, HashSet<string>> graph)
        {
            var wordLength = beginWord.Length;

            var used1 = new HashSet<string>();
            var used2 = new HashSet<string>();
            used1.Add(beginWord);
            used2.Add(endWord);

            var done = false;
            var backward = false;

            while (used1.Count != 0 && used2.Count != 0 && !done)
            {
                if (used1.Count > used2.Count)
                {
                    var temp = used1;
                    used1 = used2;
                    used2 = temp;
                    backward = !backward;
                }

                foreach (string word in used1)
                    wordList.Remove(word);
                foreach (string word in used2)
                    wordList.Remove(word);

                var current_used = new HashSet<string>();

                foreach (string word in used1)
                {
                    char[] charArray = word.ToCharArray();
                    for (int j = 0; j < wordLength; j++)
                    {
                        var temp = charArray[j];
                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            charArray[j] = ch;
                            var nextWord = new string(charArray);

                            string parent = backward ? nextWord : word;
                            string child = backward ? word : nextWord;

                            if (used2.Contains(nextWord))
                            {
                                done = true;
                                if (!graph.ContainsKey(parent)) graph.Add(parent, new HashSet<string>());
                                graph[parent].Add(child);
                            }

                            if (wordList.Contains(nextWord) && !done)
                            {
                                current_used.Add(nextWord);
                                if (!graph.ContainsKey(parent)) graph.Add(parent, new HashSet<string>());
                                graph[parent].Add(child);
                            }
                        }
                        charArray[j] = temp;
                    }
                }
                used1 = current_used;
            }

            return done;
        }
    }
}
