using NUnit.Framework;

namespace TDDKata1
{
    public class StringCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            StringCalculator stringCalculator = CreateNewStringCalculator();

            int result = stringCalculator.Add(string.Empty);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_StringWithNewLine_Sums()
        {
            //Arrange
            StringCalculator sc = CreateNewStringCalculator();
            string stringWithNewLine = "1\n2,3";

            //Act
            int result = sc.Add(stringWithNewLine);

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_StringWithOneNumber_Sums(string input, int expected)
        {
            //Arrange
            StringCalculator sc = CreateNewStringCalculator();
            string stringWithOnePositiveNumber = input;

            //Act
            int result = sc.Add(stringWithOnePositiveNumber);

            //Assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void Add_StringWithTwoNumbers_Sums()
        {
            //Arrange
            StringCalculator sc = CreateNewStringCalculator();
            string stringWithTwoPositiveNumbers = "1,2";

            //Act
            int result = sc.Add(stringWithTwoPositiveNumbers);

            //Assert
            Assert.AreEqual(3, result);
        }

        private StringCalculator CreateNewStringCalculator()
        {
            return new StringCalculator();
        }
    }
}