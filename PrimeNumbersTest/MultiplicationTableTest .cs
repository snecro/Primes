using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeNumbers;
using System.Text.RegularExpressions;

namespace PrimeNumbersTest
{
    [TestClass]
    public class MultiplicationTableTest
    {
        [TestMethod]
        public void ToString5()
        {
            PrimeNumbersMultiplicationTable table = new PrimeNumbersMultiplicationTable();
            table.GenerateNumbers(5);
            string tableAsString = table.ToString();
            
            int countRows = Regex.Matches(tableAsString, Environment.NewLine).Count;
            
            string firstRow = tableAsString.Substring(0, tableAsString.IndexOf(Environment.NewLine));
            int countColumns = Regex.Matches(firstRow, " ").Count;

            Assert.AreEqual(5 + 1, countRows);
            Assert.AreEqual(5 + 1, countColumns);
        }

        [TestMethod]
        public void ToString1()
        {
            PrimeNumbersMultiplicationTable table = new PrimeNumbersMultiplicationTable();
            table.GenerateNumbers(1);
            string tableAsString = table.ToString();

            int countRows = Regex.Matches(tableAsString, Environment.NewLine).Count;

            string firstRow = tableAsString.Substring(0, tableAsString.IndexOf(Environment.NewLine));
            int countColumns = Regex.Matches(firstRow, " ").Count;

            Assert.AreEqual(1 + 1, countRows);
            Assert.AreEqual(1 + 1, countColumns);
        }

        [TestMethod]
        public void ToString1000()
        {
            PrimeNumbersMultiplicationTable table = new PrimeNumbersMultiplicationTable();
            table.GenerateNumbers(1000);
            string tableAsString = table.ToString();

            int countRows = Regex.Matches(tableAsString, Environment.NewLine).Count;

            string firstRow = tableAsString.Substring(0, tableAsString.IndexOf(Environment.NewLine));
            int countColumns = Regex.Matches(firstRow, " ").Count;

            Assert.AreEqual(1000 + 1, countRows);
            Assert.AreEqual(1000 + 1, countColumns);
        }
    }
}
