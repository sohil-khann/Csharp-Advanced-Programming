namespace PracticeProblems.Test;

using PracticeProblems.App;

public class DateFormatterTests
{
    private DateFormatter formatter;// Instance of DateFormatter to be used in tests

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ReturnsFormattedDate()// Tests formatting of a valid date
    {
        // Arrange
        string input = "2026-01-21";
        string expected = "21-01-2026";

        // Act
        string actual = formatter.FormatDate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void FormatDate_InvalidFormat_ThrowsArgumentException()// Tests handling of an invalid date format
    {
        // Arrange
        string input = "21-01-2026"; // Wrong format

        // Act & Assert
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(input));
    }

    [Test]
    public void FormatDate_EmptyString_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(""));
    }
}
