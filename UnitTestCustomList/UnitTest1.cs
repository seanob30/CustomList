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
            numbers.InsertAt(1, 0);
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
        [TestMethod]
        public void TestRemove()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(23);
            numbers.Add(30);
            numbers.Add(35);
            //act
            numbers.Remove(35);
            //assert
            Assert.AreEqual(2, numbers.Count);
        }
        [TestMethod]
        public void TestAddTwoListsUnderCapacity()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(23);
            list1.Add(30);
            list1.Add(35);
            list1.Add(23);
            list1.Add(30);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(17);
            list2.Add(29);
            list2.Add(47);
            list2.Add(23);
            list2.Add(35);
            //act
            CustomList<int> list = list1 + list2;
            //assert
            Assert.AreEqual(10, list.Count);
        }
        [TestMethod]
        public void TestAddTwoListsOverCapacity()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(23);
            list1.Add(30);
            list1.Add(35);
            list1.Add(23);
            list1.Add(30);
            list1.Add(43);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(17);
            list2.Add(29);
            list2.Add(47);
            list2.Add(23);
            list2.Add(35);
            list2.Add(99);
            //act
            CustomList<int> list = list1 + list2;
            //assert
            Assert.AreEqual(12, list.Count);
        }
        [TestMethod]
        public void TestSubtractTwoLists()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(23);
            list1.Add(30);
            list1.Add(35);
            list1.Add(19);
            list1.Add(103);
            list1.Add(1);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(23);
            list2.Add(29);
            list2.Add(35);
            list2.Add(23);
            list2.Add(39);
            list2.Add(99);
            //act
            CustomList<int> list = list1 - list2;
            //assert
            Assert.AreEqual(4, list.Count);
        }
        [TestMethod]
        public void TestZipsTwoLists()
        {
            //arrange
            int x = 1;
            int y = 2;
            CustomList<int> newList = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            for (int i = 0; i < 20; i++, x+=2)
            { list1.InsertAt(i, x); }
            for (int i = 0; i < 10; i++, y += 2)
            { list2.InsertAt(i, y); }
            //act
            newList = list1.Zip(list2);
            //assert
            Assert.AreEqual(5, newList[4]);
        }
    }
}
