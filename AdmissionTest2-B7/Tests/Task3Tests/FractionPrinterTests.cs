using NUnit.Framework;
using Task3;

namespace Task3Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(22, 7, 50, "3.14285714285714285714285714285714285714285714285714")]
        [TestCase(11, 3, 20, "3.66666666666666666666")]
        [TestCase(0, 9, 10, "0.0000000000")]
        [TestCase(191, 37, 30, "5.162162162162162162162162162162")]
        public void Print_ValidValues_CalculatesFraction(int numerator, 
            int donominator, int count, string expectedResult)
        {
            FractionPrinter printer = new ();
            var result = printer.Print(numerator, donominator, count);
            Assert.AreEqual(expectedResult, result);
        }
    }
}