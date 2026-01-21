using NUnit.Framework;
using PracticeProblems.App;

namespace PracticeProblems.Test;

[TestFixture]
public class CalculatorTests // Unit tests for the Calculator class
{
    private Calculator calculator;// Instance of Calculator to be used in tests

    [SetUp]
    public void Setup()// Initializes the Calculator instance before each test
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSum()// Tests the Add method
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()// Tests the Subtract method
    {
        // Arrange
        int a = 20;
        int b = 8;

        // Act
        int result = calculator.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()// Tests the Multiply method
    {
        // Arrange
        int a = 4;
        int b = 6;

        // Act
        int result = calculator.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(24));
    }

    [Test]
    public void Divide_WhenCalled_ReturnsQuotient()// Tests the Divide method
    {
        // Arrange
        int a = 20;
        int b = 5;

        // Act
        int result = calculator.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()// Tests division by zero scenario
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }
}
