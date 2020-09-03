//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 27.5 MB
// Link: https://leetcode.com/submissions/detail/370337511/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /*
    // Definition for a QuadTree node.
    public class Node {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;
    
        public Node() {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }
    
        public Node(bool _val, bool _isLeaf) {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }
    
        public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
    */

    public class _0427_ConstructQuadTree
    {
        public Node Construct(int[][] grid)
        {
            var N = grid.Length;
            if (N == 0) return new Node(true, true);
            if (N == 1) return new Node(grid[0][0] == 1, true);

            return DFS(grid, 0, N, 0, N);
        }

        private Node DFS(int[][] grid, int xMin, int xMax, int yMin, int yMax)
        {
            var same = true;
            for (int i = xMin; i < xMax; i++)
            {
                for (int j = yMin; j < yMax; j++)
                    if (grid[i][j] != grid[xMin][yMin])
                    {
                        same = false;
                        break;
                    }
                if (!same) break;
            }

            if (same) return new Node(grid[xMin][yMin] == 1, true);

            var node = new Node();
            var xMid = xMin + (xMax - xMin) / 2;
            var yMid = yMin + (yMax - yMin) / 2;

            node.topLeft = DFS(grid, xMin, xMid, yMin, yMid);
            node.topRight = DFS(grid, xMin, xMid, yMid, yMax);
            node.bottomLeft = DFS(grid, xMid, xMax, yMin, yMid);
            node.bottomRight = DFS(grid, xMid, xMax, yMid, yMax);

            return node;
        }

        public class Node
        {
            public bool val;
            public bool isLeaf;
            public Node topLeft;
            public Node topRight;
            public Node bottomLeft;
            public Node bottomRight;

            public Node()
            {
                val = false;
                isLeaf = false;
                topLeft = null;
                topRight = null;
                bottomLeft = null;
                bottomRight = null;
            }

            public Node(bool _val, bool _isLeaf)
            {
                val = _val;
                isLeaf = _isLeaf;
                topLeft = null;
                topRight = null;
                bottomLeft = null;
                bottomRight = null;
            }

            public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
            {
                val = _val;
                isLeaf = _isLeaf;
                topLeft = _topLeft;
                topRight = _topRight;
                bottomLeft = _bottomLeft;
                bottomRight = _bottomRight;
            }
        }
    }
}
