using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        // Lab 4 Q8
        private FileReader getTheMagic;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();

            // Lab 4 Q8
            getTheMagic = new FileReader();
        }

        // Old add test case from Lab 1
        /*[Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act 
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }*/

        // Subtract two numbers
        [Test]
        public void Subract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(-10));
        }

        // Multiply two numbers
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        // Divide two numbers
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(10, 20);

            // Assert
            Assert.That(result, Is.EqualTo(0.5));
        }

        // Old Divide without exception handling
        /*[Test]
        public void Divide_WhenDividingByZero_ResultEqualToInfinity()
        {
            // Act
            double result = _calculator.Divide(10, 0);

            // Assert
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }*/

        // Division with exception handling
        /*[Test]
        public void Divide_WithZeroesAsInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }*/
        // Parameterized Test with divide
        /*[Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZeroesAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }*/

        // Factorial
        /*[Test]
        public void Factorial_WithNegativeNumberAsInput_ResultThrowNewArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenCalculatingFactorialZeroResultEqualToOne()
        {
            // Act 1 (Test case for factorial 0, result is 1)
            double result = _calculator.Factorial(0);
            // Assert 1
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Factorial_WhenCalculatingFactorialNonZero_ResultEqualToFactorial()
        {
            // Act 
            double result = _calculator.Factorial(3);
            // Assert 
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void Factorial_WithOverIntValueAsResult_ResultThrowNewArgumentException()
        {
            Assert.That(() => _calculator.Factorial(50), Throws.ArgumentException);
        }*/

        // Area of Triangle
        [Test]
        [TestCase(-2, 2)]
        [TestCase(2, -2)]
        [TestCase(0, 0)]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void AreaOfTriangle_WithInvalidInputs_ResultThrowNewArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }
        [Test]
        public void AreaOfTriangle_WithValidInputs_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaOfTriangle(2, 2);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        // Area of Circle
        [Test]
        [TestCase(-2)]
        [TestCase(0)]
        public void AreaOfCircle_WithInvalidInputs_ResultThrowNewArgumentException(int a)
        {
            Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
        }
        [Test]
        public void AreaOfCircle_WithValidInputs_ResultEqualToArea()
        {
            // Act
            double result = _calculator.AreaOfCircle(2);
            // Assert
            Assert.That(result, Is.EqualTo(12.566370614359172));
        }

        // Unknown Function A
        /*[Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        // Unknown Function B
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }*/

        // Lab 4 Q4 If number of lines is 4 as .txt file contatins 3, -1, 0, 1
        [Test]
        public void MagicNumber_WithChoiceNegative_ResultIsZero()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(-1, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void MagicNumber_StringRetrievedIsPositiveNumber_ResultIsDoubleTheNumber()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(0, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsNegativeNumber_ResultIsPositiveAndDoubleTheNumber()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(1, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void MagicNumber_WithStringRetrievedIsZero_ResultIsZero()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(2, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithChoiceNumberEqualsToNumberOfLines_ResultIsZero()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(4, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void MagicNumber_WithChoiceMoreThanNumberOfLines_ResultIsZero()
        {
            // Act Q8
            double result = _calculator.GenMagicNum(5, getTheMagic);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}