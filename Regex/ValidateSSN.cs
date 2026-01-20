/*15. Validate a Social Security Number (SSN) 
 Example Input: "My SSN is 123-45-6789." 
 Expected Output: 
 ● ✅ "123-45-6789" is valid 
 ● ❌ "123456789" is invalid */

using System.Text.RegularExpressions;

public class ValidateSSN
{
    public static void Validate(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        if (Regex.IsMatch(ssn, pattern))
        {
            Console.WriteLine($" \"{ssn}\" is valid");
        }
        else
        {
            Console.WriteLine($" \"{ssn}\" is invalid");
        }
    }
}
