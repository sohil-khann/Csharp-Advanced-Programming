namespace PracticeProblems.Test;

using PracticeProblems.App;

[TestFixture]
public class MathUtilsTests
{
    [Test]
    public void Divide_WhenDivisorIsZero_ShouldThrowArithmeticException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<ArithmeticException>(() => MathUtils.Divide(a, b));
    }

    [Test]
    public void Divide_WhenDivisorIsNotZero_ShouldReturnCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 2;
        int expected = 5;

        // Act
        int result = MathUtils.Divide(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
