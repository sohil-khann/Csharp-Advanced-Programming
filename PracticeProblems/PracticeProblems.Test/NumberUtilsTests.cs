namespace PracticeProblems.Test;

using PracticeProblems.App;

public class NumberUtilsTests
{
    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = NumberUtils.IsEven(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
