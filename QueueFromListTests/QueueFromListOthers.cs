using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueFromListTests
{
    [TestClass]
    public class QueueFromListOthers
    {
        [TestMethod]
        public void PeekTest()
        {
            // arrange
            QueueFromList<int> testQueue = new QueueFromList<int>(6, 1, 2, 3, 4);
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
            QueueFromList<int> actual = new QueueFromList<int>(6, 1, 2, 3, 4);
            QueueFromList<int> expected = new QueueFromList<int>();

            // act
            actual.Clear();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
