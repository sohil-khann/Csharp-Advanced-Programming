using PracticeProblems.App;

namespace PracticeProblems.Test;

public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void IsValid_WhenPasswordIsValid_ReturnsTrue()
    {
        // Arrange
        string validPass = "StrongPass123";

        // Act
        bool result = validator.IsValid(validPass);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_WhenPasswordIsTooShort_ReturnsFalse()
    {
        // Arrange
        string shortPass = "Up1";

        // Act
        bool result = validator.IsValid(shortPass);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_WhenPasswordHasNoUpperCase_ReturnsFalse()
    {
        // Arrange
        string noUpper = "lowercase123";

        // Act
        bool result = validator.IsValid(noUpper);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_WhenPasswordHasNoDigit_ReturnsFalse()
    {
        // Arrange
        string noDigit = "NoDigitsHere";

        // Act
        bool result = validator.IsValid(noDigit);

        // Assert
        Assert.That(result, Is.False);
    }
}
