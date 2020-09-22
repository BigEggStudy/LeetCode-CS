using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCode._0708_InsertIntoASortedCircularLinkedList;

namespace LeetCode.Test
{
    [TestClass]
    public class _0708_InsertIntoASortedCircularLinkedList_Test
    {
        [TestMethod]
        public void Insert_1()
        {
            var node1 = new Node(1);
            var node3 = new Node(3);
            var node4 = new Node(4);

            node1.next = node3;
            node3.next = node4;
            node4.next = node1;

            var solution = new _0708_InsertIntoASortedCircularLinkedList();
            var result = solution.Insert(node3, 2);
            Assert.AreEqual(3, result.val);
            Assert.AreEqual(4, result.next.val);
            Assert.AreEqual(1, result.next.next.val);
            Assert.AreEqual(2, result.next.next.next.val);
            Assert.AreEqual(3, result.next.next.next.next.val);
        }

        [TestMethod]
        public void Insert_2()
        {
            var solution = new _0708_InsertIntoASortedCircularLinkedList();
            var result = solution.Insert(null, 1);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(1, result.next.val);
        }

        [TestMethod]
        public void Insert_3()
        {
            var node1 = new Node(1);
            node1.next = node1;

            var solution = new _0708_InsertIntoASortedCircularLinkedList();
            var result = solution.Insert(node1, 0);
            Assert.AreEqual(1, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(1, result.next.next.val);
        }
    }
}
