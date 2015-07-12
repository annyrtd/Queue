using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueTests
{
    [TestClass]
    public class QueueTestsOthers
    {
        [TestMethod]
        public void PeekTest()
        {
            // arrange
            Queue<int> testQueue = new Queue<int>(6,1,2,3,4);
            int expected = 6;

            // act
            int actual = testQueue.Peek();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClearTest()
        {
            // arrange
            Queue<int> actual = new Queue<int>(6, 1, 2, 3, 4);
            Queue<int> expected = new Queue<int>();

            // act
           actual.Clear();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
