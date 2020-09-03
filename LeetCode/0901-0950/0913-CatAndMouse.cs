//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0913_CatAndMouse
    {
        private const int DRAW = 0, MOUSE_WIN = 1, CAT_WIN = 2, MOUSE_TURN = 0, CAT_TURN = 1;

        public int CatMouseGame(int[][] graph)
        {
            var N = graph.Length;

            var degrees = new int[N, N, 2];
            var colors = new int[N, N, 2];
            var visited = new bool[N, N, 2];

            for (int mouseIndex = 0; mouseIndex < N; mouseIndex++)
                for (int catIndex = 0; catIndex < N; catIndex++)
                {
                    degrees[mouseIndex, catIndex, MOUSE_TURN] = graph[mouseIndex].Length;
                    degrees[mouseIndex, catIndex, CAT_TURN] = graph[catIndex].Length;

                    if (graph[catIndex].Contains(0)) degrees[mouseIndex, catIndex, CAT_TURN]--;
                }

            var queue = new Queue<(int mouseIndex, int catIndex, int turn, int color)>();
            for (int catIndex = 1; catIndex < N; catIndex++)
                for (int turn = 0; turn < 2; turn++)
                {
                    colors[0, catIndex, turn] = MOUSE_WIN;
                    queue.Enqueue((0, catIndex, turn, MOUSE_WIN));
                    visited[0, catIndex, turn] = true;

                    colors[catIndex, catIndex, turn] = CAT_WIN;
                    queue.Enqueue((catIndex, catIndex, turn, CAT_WIN));
                    visited[catIndex, catIndex, turn] = true;
                }

            while (queue.Count > 0)
            {
                (int mouseIndex, int catIndex, int turn, int color) = queue.Dequeue();
                foreach (var parent in GetParents(graph, mouseIndex, catIndex, turn))
                {
                    if (visited[parent.mouseIndex, parent.catIndex, parent.turn]) continue;

                    if (colors[parent.mouseIndex, parent.catIndex, parent.turn] == DRAW)
                    {
                        if ((parent.turn == MOUSE_TURN && color == MOUSE_WIN) || (parent.turn == CAT_TURN && color == CAT_WIN))
                        {
                            if (parent.mouseIndex == 1 && parent.catIndex == 2 && parent.turn == MOUSE_TURN)
                                return color;

                            colors[parent.mouseIndex, parent.catIndex, parent.turn] = color;
                            queue.Enqueue((parent.mouseIndex, parent.catIndex, parent.turn, color));
                            visited[parent.mouseIndex, parent.catIndex, parent.turn] = true;
                        }
                        else
                        {
                            degrees[parent.mouseIndex, parent.catIndex, parent.turn]--;
                            if (degrees[parent.mouseIndex, parent.catIndex, parent.turn] == 0)
                            {
                                var nextColor = parent.turn == MOUSE_TURN ? CAT_WIN : MOUSE_WIN;
                                if (parent.mouseIndex == 1 && parent.catIndex == 2 && parent.turn == MOUSE_TURN)
                                    return nextColor;

                                colors[parent.mouseIndex, parent.catIndex, parent.turn] = nextColor;
                                queue.Enqueue((parent.mouseIndex, parent.catIndex, parent.turn, nextColor));
                                visited[parent.mouseIndex, parent.catIndex, parent.turn] = true;
                            }
                        }
                    }
                }
            }

            return colors[1, 2, MOUSE_TURN];
        }

        private IList<(int mouseIndex, int catIndex, int turn)> GetParents(int[][] graph, int mouseIndex, int catIndex, int turn)
        {
            var result = new List<(int mouseIndex, int catIndex, int turn)>();
            if (turn == CAT_TURN)
                foreach (var newMouseIndex in graph[mouseIndex])
                    result.Add((newMouseIndex, catIndex, MOUSE_TURN));
            else
                foreach (var newCatIndex in graph[catIndex])
                    if (newCatIndex > 0)
                        result.Add((mouseIndex, newCatIndex, CAT_TURN));
            return result;
        }
    }
}
