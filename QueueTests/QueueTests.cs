using System;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueTests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Enqueue_NextIndexLessThanArrayLength()
        {
            // arrange
            Queue<int> expected = new Queue<int>(5);
            Queue<int> actual = new Queue<int>();
            
            // act
            actual.Enqueue(5);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enqueue_NextIndexGreaterThanArrayLength()
        {
            // arrange
            Queue<int> expected = new Queue<int>(1, 2, 3, 4, 5, 6);
            Queue<int> actual = new Queue<int>(1, 2, 3, 4, 5);
            
            // act
            actual.Enqueue(6);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enqueue_NextIndexGreaterThanArrayLength_ResizeArray()
        {
            // arrange
            Queue<int> actual = new Queue<int>(1, 2, 3, 4, 5);
            int expected = 10;

            // act
            actual.Enqueue(6);

            // assert
            Assert.AreEqual(expected, actual.Items.Length);
        }
    }
}
