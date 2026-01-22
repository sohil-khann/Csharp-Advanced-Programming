namespace PracticeProblems.App;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password)) return false;
        
        // Passwords must have at least 8 characters
        if (password.Length < 8) return false;

        bool hasUpperCase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpperCase = true;
            if (char.IsDigit(c)) hasDigit = true;
        }

        return hasUpperCase && hasDigit;
    }
}
