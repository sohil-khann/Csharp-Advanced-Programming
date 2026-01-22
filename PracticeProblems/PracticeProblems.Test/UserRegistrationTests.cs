namespace PracticeProblems.Test;

using PracticeProblems.App;

public class UserRegistrationTests
{
    private UserRegistration registration;

    [SetUp]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInputs_ReturnsTrue()
    {
        bool result = registration.RegisterUser("john_doe", "john@example.com", "SecurePass123");
        Assert.That(result, Is.True);
    }

    [Test]
    public void RegisterUser_EmptyUsername_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => 
            registration.RegisterUser("", "test@test.com", "Password123"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => 
            registration.RegisterUser("user123", "invalid-email", "Password123"));
    }

    [Test]
    public void RegisterUser_ShortPassword_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => 
            registration.RegisterUser("user123", "test@test.com", "Short1"));
    }
}
