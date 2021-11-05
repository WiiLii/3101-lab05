using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    class FileReaderBasic
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Lab 4 Q4 If number of lines is 4 as .txt file contatins 3, -1, 0, 1
            _calculator = new Calculator();
        }

        [Test]
        public void MagicNumber_WithChoiceNegative_ResultIsZero()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(-1);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void MagicNumber_StringRetrievedIsPositiveNumber_ResultIsDoubleTheNumber()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(0);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsNegativeNumber_ResultIsPositiveAndDoubleTheNumber()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(1);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsZero_ResultIsZero()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(2);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithChoiceNumberEqualsToNumberOfLines_ResultIsZero()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(4);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithChoiceMoreThanNumberOfLines_ResultIsZero()
        {
            // Act Q4
            double result = _calculator.GenMagicNumBase(5);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
