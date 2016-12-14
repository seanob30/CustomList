using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCount()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            //act
            for (int i = 0; i < 7; i++)
            {
                numbers.Add(i);
            }
            //assert
            Assert.AreEqual(7, numbers.Count);
        }
        [TestMethod]
        public void TestGetCapacity()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            //act
            //assert
            Assert.AreEqual(10, numbers.Capacity);
        }
        [TestMethod]
        public void TestAddItemUnderCapacity()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            for (int i = 0; i < 7; i++)
            {
                numbers.Add(i);
            }
            //act
            int eight = 8;
            numbers.Add(eight);
            //assert
            Assert.AreEqual(8, numbers.Count);
        }
        [TestMethod]
        public void TestAddItemOverCapacity()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            for (int i = 0; i < 14; i++)
            {
                numbers.Add(i);
            }
            //act
            int fifteen = 15;
            numbers.Add(fifteen);
            //assert
            Assert.AreEqual(20, numbers.Capacity);
        }
        [TestMethod]
        public void TestReadIndex()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            //act
            numbers.Add(23);
            numbers.Add(30);
            numbers.Add(35);
            numbers.Add(17);
            numbers.Add(29);
            numbers.Add(47);
            //assert
            Assert.AreEqual(17, numbers.ReadIndex(3));
        }
        [TestMethod]
        public void TestInsertItemInList()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(23);
            numbers.Add(30);
            numbers.Add(35);
            //act
            numbers.Insert(1, 0);
            //assert
            Assert.AreEqual(numbers.ReadIndex(1), 0);
        }
        [TestMethod]
        public void TestRemoveAtIndex()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(23);
            numbers.Add(30);
            numbers.Add(35);
            //act
            numbers.RemoveAt(1);
            //assert
            Assert.AreEqual(numbers.ReadIndex(1), 0);
        }
        [TestMethod]
        public void TestIndexOf()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            //act
            numbers.Add(23);
            numbers.Add(30);
            numbers.Add(35);
            numbers.Add(17);
            numbers.Add(29);
            numbers.Add(47);
            //assert
            Assert.AreEqual(2, numbers.IndexOf(35));
        }
    }
}
