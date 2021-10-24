using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeNumbers;

namespace PrimeNumbersTest
{
    [TestClass]
    public class PrimeNumbersMultiplicationTableTest
    {
        [TestMethod]
        public void GenerateNumbersTest5()
        {
            string expected = "2 3 5 7 11";
            PrimeNumbersMultiplicationTable table = new PrimeNumbersMultiplicationTable();
            table.GenerateNumbers(5);
            string rows = string.Join(" ", table.Rows);
            string columns = string.Join(" ", table.Columns);
            Assert.AreEqual(expected, rows);
            Assert.AreEqual(expected, columns);
        }

        [TestMethod]
        public void GenerateNumbersTest1()
        {
            string expected = "2";
            PrimeNumbersMultiplicationTable table = new PrimeNumbersMultiplicationTable();
            table.GenerateNumbers(1);
            string rows = string.Join(" ", table.Rows);
            string columns = string.Join(" ", table.Columns);
            Assert.AreEqual(expected, rows);
            Assert.AreEqual(expected, columns);
        }
    }
}
