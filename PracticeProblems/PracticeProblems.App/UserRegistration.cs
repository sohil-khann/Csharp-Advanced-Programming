namespace PracticeProblems.App;

public class UserRegistration// Class for user registration functionality
{
    public bool RegisterUser(string username, string email, string password)// Method to register a user
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("Username cannot be empty.");
        }

        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
        {
            throw new ArgumentException("Invalid email format.");
        }

        if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters long.");
        }

        // Simulate registration success
        Console.WriteLine($"User {username} registered successfully.");
        return true;
    }
}
