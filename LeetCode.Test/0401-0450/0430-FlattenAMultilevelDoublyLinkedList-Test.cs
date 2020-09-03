using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._0430_FlattenAMultilevelDoublyLinkedList;

namespace LeetCode.Test
{
    [TestClass]
    public class _0430_FlattenAMultilevelDoublyLinkedList_Test
    {
        //[TestMethod]
        //public void Flatten_1()
        //{
        //    var solution = new _0430_FlattenAMultilevelDoublyLinkedList();
        //    var result = solution.Flatten(INPUT_PLACEHOLDER);
        //    Assert.AreEqual(EXPECTED, result);
        //}

        [TestMethod]
        public void Flatten_2()
        {
            var node1 = new Node() { val = 1 };
            var node2 = new Node() { val = 2 };
            var node3 = new Node() { val = 3 };

            node1.next = node2;
            node2.prev = node1;
            node1.child = node3;

            var solution = new _0430_FlattenAMultilevelDoublyLinkedList();
            var resultNode1 = solution.Flatten(node1);
            Assert.AreEqual(1, resultNode1.val);
            Assert.IsNull(resultNode1.child);

            var resultNode2 = resultNode1.next;
            Assert.AreEqual(3, resultNode2.val);
            Assert.IsNull(resultNode2.child);
            Assert.AreEqual(2, resultNode2.next.val);
            Assert.AreEqual(1, resultNode2.prev.val);

            var resultNode3 = resultNode2.next;
            Assert.AreEqual(2, resultNode3.val);
            Assert.IsNull(resultNode3.child);
            Assert.AreEqual(3, resultNode3.prev.val);
        }

        [TestMethod]
        public void Flatten_3()
        {
            var solution = new _0430_FlattenAMultilevelDoublyLinkedList();
            var result = solution.Flatten(null);
            Assert.IsNull(result);
        }
    }
}
