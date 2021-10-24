using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PrimeNumbers;

namespace PrimeNumbersTest
{
    [TestClass]
    public class PrimeNumberTest
    {

        [TestMethod]
        public void IsPrimeTest12363()
        {
            bool output = PrimeNumber.Instance.IsPrime(12363);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void IsPrimeTest73()
        {
            bool output = PrimeNumber.Instance.IsPrime(73);
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void IsPrimeTest1()
        {
            bool output = PrimeNumber.Instance.IsPrime(1);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void IsPrimeTest7()
        {
            bool output = PrimeNumber.Instance.IsPrime(7);
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void IsPrimeTest10()
        {
            bool output = PrimeNumber.Instance.IsPrime(10);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void IsPrimeTest13()
        {
            bool output = PrimeNumber.Instance.IsPrime(13);
            Assert.IsTrue(output);
        }
    }
}
