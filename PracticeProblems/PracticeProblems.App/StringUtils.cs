namespace PracticeProblems.App;

public class StringUtils// Class for string utility methods
{
    public string Reverse(string str)// Method to reverse a string
    {
        if (string.IsNullOrEmpty(str)) return str;
        
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public bool IsPalindrome(string str)// Method to check if a string is a palindrome
    {
        if (string.IsNullOrEmpty(str)) return true;
        
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)// Method to convert a string to uppercase
    {
        if (str == null) return null!;
        return str.ToUpper();
    }
}
