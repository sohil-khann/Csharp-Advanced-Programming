using PracticeProblems.App;

namespace PracticeProblems.Test;

public class StringUtilsTests
{
    private StringUtils stringUtils;

    [SetUp]
    public void Setup()
    {
        stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_WhenCalled_ReturnsReversedString()
    {
        string input = "hello";
        string expected = "olleh";

        string result = stringUtils.Reverse(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void IsPalindrome_WhenPalindrome_ReturnsTrue()
    {
        string input = "madam";

        bool result = stringUtils.IsPalindrome(input);

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_WhenNotPalindrome_ReturnsFalse()
    {
        string input = "hello";

        bool result = stringUtils.IsPalindrome(input);

        Assert.That(result, Is.False);
    }

    [Test]
    public void ToUpperCase_WhenCalled_ReturnsUpperCaseString()
    {
        string input = "hello";
        string expected = "HELLO";

        string result = stringUtils.ToUpperCase(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
