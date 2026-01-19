/*2. Validate a License Plate Number
License plate format: Starts with two uppercase letters, followed by four digits.
Example: "AB1234" is valid, but "A12345" is invalid.*/

using System.Text.RegularExpressions;

public class ValidateNumberPlate
{
    public static void Validate(String input)
    {
        String pattern=@"[A-Z]{2}[0-9]{4}";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid number plate");
            return;
        }
        else
        {
            Console.WriteLine("Not Valid");
        }

    }
    
}