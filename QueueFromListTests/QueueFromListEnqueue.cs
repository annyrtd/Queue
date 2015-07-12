using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueFromListTests
{
    [TestClass]
    public class QueueFromListEnqueue
    {
        [TestMethod]
        public void Enqueue_HeadIsNull()
        {
            // arrange
            QueueFromList<int> actual = new QueueFromList<int>();
            QueueFromList<int> expected = new QueueFromList<int>(5);

            // act
            actual.Enqueue(5);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enqueue_HeadIsNotNull()
        {
            // arrange
            QueueFromList<int> actual = new QueueFromList<int>(5,6,7);
            QueueFromList<int> expected = new QueueFromList<int>(5,6,7,8);

            // act
            actual.Enqueue(8);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
