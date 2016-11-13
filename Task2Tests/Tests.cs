using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;
using TestClassesTask2;

namespace Task2Tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void Test1()
        {
            TestClassSumUp obj = new TestClassSumUp();
            int[][] array = new int[][] { new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, new[] { 0, 5, 6, 7, 0, 4 } };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] { new[] { 2, 3, 4 },new[] { 1, 2, 3, 4 }, new[] { 0, 5, 6, 7, 0, 4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[]  { 5, 5, 55555 }},array);

        }
        [Test]
        public void Test2()
        {
            TestClassSumDown obj = new TestClassSumDown();
            int[][] array = new int[][] { new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, new[] { 0, 5, 6, 7, 0, 4 } };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] {   new[] { 5, 5, 55555 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 0, 5, 6, 7, 0, 4 }, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }},array);

        }
        [Test]
        public void Test3()
        {
            TestClassSumDown obj = new TestClassSumDown();
            int[][] array = new int[][] { new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, null, new[] { 5, 5, 55555 }, new[] { 0, 5, 6, 7, 0, 4 } ,null};
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] { new[] { 5, 5, 55555 },  new[] { 0, 5, 6, 7, 0, 4 }, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, null, null }, array);

        }
        [Test]
        public void Test4()
        {
            TestClassSumUp obj = new TestClassSumUp();
            int[][] array = new int[][] { null,new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 },null,null, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 },null,null, new[] { 0, 5, 6, 7, 0, 4 } };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] { new[] { 2, 3, 4 }, new[] { 1, 2, 3, 4 }, new[] { 0, 5, 6, 7, 0, 4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null, null, null, null }, array);

        }
        [Test]
        public void Test5()
        {
            TestClassMaxElemUp obj = new TestClassMaxElemUp();
            int[][] array = new int[][] { null, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, null, null, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null, new[] { 0, 5, 6, 7, 0, 4 } };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] {  new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, new[] { 0, 5, 6, 7, 0, 4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null, null, null, null }, array);

        }
        [Test]
        public void Test6()
        {
            TestClassMaxElemDown obj = new TestClassMaxElemDown();
            int[][] array = new int[][] { null, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 }, null, null, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null, new[] { 0, 5, 6, 7, 0, 4 } };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] {  new[] { 5, 5, 55555 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 0, 5, 6, 7, 0, 4 }, new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 } , null, null, null, null, null}, array);

        }
        [Test]
        public void Test7()
        {
            TestClassMinElemDown obj = new TestClassMinElemDown();
            int[][] array = new int[][] { null, new[] { -1001, 2, 3, 4 }, new[] { 2, 3, -4 }, null, null, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] {new[] { -1001, 2, 3, 4 }, new[] { 2, 3, -4 }, new[] { 4, 5, 6, 7, 432, 4 }, new[] { 5, 5, 55555 }, null, null, null, null, null}, array);

        }
        [Test]
        public void Test8()
        {
            TestClassMinElemUp obj = new TestClassMinElemUp();
            int[][] array = new int[][] { null, new[] { 100,-3 }, new[] { 2, -1000, 4 }, null };
            MatrixFuncInterface.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] {  new[] { 100, -3 }, new[] { 2, -1000, 4 }, null, null }, array);

        }
        /////////////////////////////////////
        /////////////////////////////////////
        //Testing with Delegate
        [Test]
        public void Test9()
        {
            Comparison<int[]> compDelegate = (new TestClassMaxElemDown()).Compare;
            int[][] array = new int[][] { null, new[] { 100, -3 }, new[] { 2, -1000, 4 }, null };
            MatrixFuncInterface.BubbleSort(array, compDelegate);
            Assert.AreEqual(new int[][] { new[] { 100, -3 }, new[] { 2, -1000, 4 },null, null }, array);

        }
        [Test]
        public void Test10()
        {
            TestClassMaxElemDown obj = new TestClassMaxElemDown();
            int[][] array = new int[][] { null, new[] { 100, -3 }, new[] { 2, -1000, 4 }, null };
            MatrixFuncDelegate.BubbleSort(array, obj);
            Assert.AreEqual(new int[][] { new[] { 100, -3 }, new[] { 2, -1000, 4 }, null, null }, array);

        }
        [Test]
        public void Test11()
        {
            Comparison<int[]> compDelegate = (new TestClassMaxElemDown()).Compare;
            int[][] array = new int[][] { null, new[] { 100, -3 }, new[] { 2, -1000, 4 }, null };
            MatrixFuncDelegate.BubbleSort(array, compDelegate);
            Assert.AreEqual(new int[][] { new[] { 100, -3 }, new[] { 2, -1000, 4 }, null, null }, array);

        }

    }
}
