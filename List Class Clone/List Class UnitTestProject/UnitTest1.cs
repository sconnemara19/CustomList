using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List_Class_Clone;
namespace List_Class_UnitTestProject
{
    [TestClass]
    public class ListClassUnitTest1
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

        [TestMethod]
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
        [TestMethod]
        public void Remove_RemoveTheFirstOccurence()

        {
            //arrange 
            CustomList<int> testList = new CustomList<int>();
            int expected = 19;

            //act

            testList.Add(60);
            testList.Add(23);
            testList.Add(86);
            testList.Add(19);
            testList.Add(44);
            testList.Add(19);
            testList.Remove(19);

            int actual = testList[3];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Removebaseon_Value()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 23;

            testList.Add(12);
            testList.Add(43);
            testList.Add(88);
            testList.Add(90);
            testList.Add(10);
            testList.Add(23);
            testList.Add(6);
            testList.Remove(10);

            int actual = testList[4];
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void  Remove_RemoveFromEmptyList_ToCheckPosition()
        {
            //arrange
            CustomList<int> testlist = new CustomList<int>();

            int expected = 0;
            int actual;

            //act
            testlist.Remove(0);
            actual = testlist.Count;
            //assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void String_ConvertToString()
        {
            //arrange
            CustomList<int> testlist = new CustomList<int>();
            string expected = "123";
            string actual;


            //act
            testlist.Add(1);
            testlist.Add(2);
            testlist.Add(3);

            actual = testlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }  
        [TestMethod]
        public void String_NumberToString()
        {   
            //arrange
            CustomList<string> testlist = new CustomList<string>();
            string expected = "HelloWorld";
            string actual;

            //act
            testlist.Add("Hello");
            testlist.Add("World");
            

            actual = testlist.ToString();

            //assert
            Assert.AreEqual(expected, actual);



        }


       


    }
}
