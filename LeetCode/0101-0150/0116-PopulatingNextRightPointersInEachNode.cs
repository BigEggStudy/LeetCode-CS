//-----------------------------------------------------------------------------
// Runtime: 164ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0116_PopulatingNextRightPointersInEachNode
    {
        public TreeLinkNode Connect(TreeLinkNode root)
        {
            TreeLinkNode levelStart = root;
            while (levelStart != null)
            {
                TreeLinkNode cur = levelStart;
                while (cur != null)
                {
                    if (cur.left != null) cur.left.next = cur.right;
                    if (cur.right != null && cur.next != null) cur.right.next = cur.next.left;

                    cur = cur.next;
                }
                levelStart = levelStart.left;
            }

            return root;
        }
    }
}
