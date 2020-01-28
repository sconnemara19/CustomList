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
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveTheFirstOccurence()

        {
            //arrange 
            CustomList<int> testList = new CustomList<int>();
            int expected = 44;

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
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFromEmptyList_ToCheckPosition()
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
        [TestMethod]
        public void String_NumberToStringAgain()
        {

            CustomList<string> testList = new CustomList<string>();
            string expected = "strangerthingsisawesome";
            string actual;


            testList.Add("stranger");
            testList.Add("things");
            testList.Add("is");
            testList.Add("awesome");
            actual = testList.ToString();


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_AddTwoList()
        {
            CustomList<int> testlist = new CustomList<int>();
            CustomList<int> testlist2 = new CustomList<int>();
            CustomList<int> testlist3 = new CustomList<int>();
            int expected = 1;
            int actual;
            testlist.Add(1);
            testlist.Add(2);
            testlist.Add(3);
            testlist2.Add(4);
            testlist2.Add(5);
            testlist2.Add(6);

            testlist3 = testlist + testlist2;
            actual = testlist3[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_IndexOneIsTwo()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 2;
            int actual;


            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList3 = testList1 + testList2;
            actual = testList3[1];


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_IndexTwoIsThree()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 3;
            int actual;


            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList3 = testList1 + testList2;
            actual = testList3[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_IndexThreeIsFour()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testlist3 = new CustomList<int>();
            int expected = 4;
            int actual;


            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testlist3 = testList1 + testList2;
            actual = testlist3[3];


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverload_IndexFiveIsSix()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testlist3 = new CustomList<int>();
            int expected = 6;
            int actual;


            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testlist3 = testList1 + testList2;
            actual = testlist3[5];



            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOverload_RemoveItems()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;


            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(2);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            testList = testList1 - testList2;
            actual = testList.Count;


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_Removeitems_IndexZeroIsThree()
        {

            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(4);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            testList = testList1 - testList2;
            actual = testList[0];


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_IndexZeroIsSix()
        {

            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>();
            int expected = 6;
            int actual;


            testList1.Add(1);
            testList1.Add(4);
            testList1.Add(2);
            testList2.Add(5);
            testList2.Add(2);
            testList2.Add(6);
            testList = testList1 - testList2;
            actual = testList[0];


            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void MinusOverload__IndexOneIsThree()
        {

            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 3;
            int actual;


            testList1.Add(5);
            testList1.Add(4);
            testList1.Add(9);
            testList2.Add(8);
            testList2.Add(3);
            testList2.Add(2);
            newList = testList1 - testList2;
            actual = newList[1];


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOverload_Duplicate()
        {

            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 7;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(7);
            testList2.Add(1);
            testList2.Add(2);
            testList2.Add(7);
            testList2.Add(6);
            testList3 = testList1 - testList2;
            actual = testList3[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ZipTwoCustomListsTogether()
        {
            // arrange
            CustomList<int> testlist1 = new CustomList<int>();
            CustomList<int> testlist2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 8;
            int actual;

            // act
            testlist1.Add(1);
            testlist1.Add(3);
            testlist1.Add(6);
            testlist2.Add(5);
            testlist2.Add(4);
            testlist2.Add(8);
            newList = testlist1.Zip(testlist2);
            actual = newList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_IndexZeroIsOne()
        {
            // arrange
            CustomList<int> testlist1 = new CustomList<int>();
            CustomList<int> testlist2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testlist1.Add(1);
            testlist1.Add(3);
            testlist1.Add(5);
            testlist2.Add(2);
            testlist2.Add(4);
            testlist2.Add(6);
            newList = testlist1.Zip(testlist2);
            actual = newList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_IndexFiveIsSix()
        {
            // arrange
            CustomList<int> testlist1 = new CustomList<int>();
            CustomList<int> testlist2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            testlist1.Add(1);
            testlist1.Add(3);
            testlist1.Add(5);
            testlist2.Add(2);
            testlist2.Add(4);
            testlist2.Add(6);
            newList = testlist1.Zip(testlist2);
            actual = newList[5];

            // assert
            Assert.AreEqual(expected, actual);
        }



    }
}
