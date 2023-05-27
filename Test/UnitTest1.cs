using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1, 2)]
        [TestCase(1, 3, 4)]
        [TestCase(10, 1, 11)]
        public void Test1(int n1, int n2, int expected)
        {
            var result = Calculate.Sum(n1, n2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestArray()
        {
            //Look through a 2D array
            int[,] numbers = { { 1, 4, 5 }, { 3, 8, 7 }, { 2, 5, 0 } };
            var result = "";
            for (int i = 0; i < numbers.GetLength(0)/*=2*/; i++)
            {
                for (int j = 0; j < numbers.GetLength(1)/*=3*/; j++)
                {
                    result += "_" + numbers[i, j].ToString();//1 4 5 3 8 7
                }
            }

            var expected = "_1_4_5_3_8_7_2_5_0";

            Assert.AreEqual(expected, result);
        }
    }
}