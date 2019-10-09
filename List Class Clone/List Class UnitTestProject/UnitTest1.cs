using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List_Class_Clone;
namespace List_Class_UnitTestProject
{
    [TestClass]
    public class ListClassUnitTest1<T>
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            //arrange

            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            //act
            testList.Add(12);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AdditemtoList_CountIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            testList.Add(234);
            actual = testList.Count;

        }
        [TestMethod]
        public void Add_AddMulitpleItemstoList_ToCheckPosition()
        {   //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);

            int actual = testList[3];

            //assert
            Assert.AreEqual(expected, actual);
         

          
        }

        public void Add_AdditemstoList_CheckPosition()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 23;
            


            //act

            testList.Add(56);
            testList.Add(43);
            testList.Add(87);
            testList.Add(90);
            testList.Add(44);
            testList.Add(23);
            testList.Add(6);

            int actual = testList[5];

            Assert.AreEqual(expected, actual);
        }





    }
}
