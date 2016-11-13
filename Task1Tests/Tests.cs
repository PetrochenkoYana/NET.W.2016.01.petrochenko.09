using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Task1;
namespace Task1Tests
{
    [TestFixture]
    class Tests
    {
        private long time;
        [Test]
        public void Test1()
        {
            Assert.AreEqual(21, GcdMethods.GcdEuclid( 1071, 462,out time));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test2()
        {
            
            Assert.AreEqual(21, GcdMethods.GcdEuclid(462, 1071, out time));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(21, GcdMethods.GcdEuclid(462, 1071,21, out time));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(21, GcdMethods.GcdEuclid(462, 1071, 0, out time));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(1, GcdMethods.GcdEuclid(462, 1071,467, out time));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(1, GcdMethods.GcdEuclid(out time, 462, 1071, 21,1,5,7));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(1, GcdMethods.GcdEuclid(out time, 462, 1071, 467,0,0));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(7, GcdMethods.GcdEuclid(out time, 462, 1071,42,84,7));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual(3, GcdMethods.GcdEuclid(out time, 462, 1071,3,3,3,3,3,3,3,3,21));
            Console.WriteLine(time.ToString());
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(1, GcdMethods.GcdEuclid(out time, 462, 1071, 467,0,0,0,0,0,0,5));
            Console.WriteLine(time.ToString());
        }
        [Test]
        public void Test11()
        {
            Assert.AreEqual(1, GcdMethods.GcdEuclid(out time, - 462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));
            Console.WriteLine(time.ToString());
        }

        /// <summary>
        /// the beginning of tests for BinaryGcd
        /// </summary>
        [Test]
        public void Test12()
        {
            Assert.AreEqual(21, GcdMethods.GcdBinary(462,1071));
           
        }
        [Test]
        public void Test13()
        {
            Assert.AreEqual(21, GcdMethods.GcdBinary(462, 1071,0));

        }
        [Test]
        public void Test14()
        {
            Assert.AreEqual(3, GcdMethods.GcdBinary(462, 1071, 3, 3, 3, 3, 3, 3, 3, 3, 21));

        }
        [Test]
        public void Test15()
        {
            Assert.AreEqual(1, GcdMethods.GcdBinary(-462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));

        }
        [Test]
        public void Test16()
        {
            Assert.AreEqual(21, GcdMethods.GcdBinary(462, -1071, 0));

        }
        [Test]
        public void Test17()
        {
            Assert.AreEqual(3, GcdMethods.GcdBinary(462, 1071, 3, 3, 3, -3, 3, 3, 3,-3, 21));

        }
        [Test]
        public void Test18()
        {
            Assert.AreEqual(1, GcdMethods.GcdBinary(-462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));

        }
        [Test]
        public void Test19()
        {
            Assert.AreEqual(1, GcdMethods.GcdBinary(out time, -462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));
            Console.WriteLine(time.ToString());
        }

    }
}
