/*1. Validate a Username
A valid username:
 Can only contain letters (a-z, A-Z), numbers (0-9), and underscores (_)
 Must start with a letter
 Must be between 5 to 15 characters long
Example Inputs & Outputs:
 "user_123" → Valid
 "123user" → Invalid (starts with a number)
 "us" → Invalid (too short)*/
using System.Text.RegularExpressions;

 public class ValidateUsername
{
    public static bool Validate(String user)
    {
        string pattern= @"^[a-zA-Z][a-z A-Z _ \d]{5,15}";
        
            if (Regex.IsMatch(user, pattern))
            {
                
                return true;
            }


        
             return false;
    }
}
