//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0117_PopulatingNextRightPointersInEachNode2
    {
        public TreeLinkNode Connect(TreeLinkNode root)
        {
            TreeLinkNode cur = root;
            while (cur != null)
            {
                TreeLinkNode nextHead = null;
                TreeLinkNode nextPrevious = null;
                while (cur != null)
                {
                    if (cur.left != null)
                    {
                        if (nextPrevious != null)
                            nextPrevious.next = cur.left;
                        else
                            nextHead = cur.left;
                        nextPrevious = cur.left;
                    }

                    if (cur.right != null)
                    {
                        if (nextPrevious != null)
                            nextPrevious.next = cur.right;
                        else
                            nextHead = cur.right;
                        nextPrevious = cur.right;
                    }

                    cur = cur.next;
                }

                cur = nextHead;
            }

            return root;
        }
    }
}
