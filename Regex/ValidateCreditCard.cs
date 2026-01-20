/*11. Validate a Credit Card Number (Visa, MasterCard, etc.) 
 ● A Visa card number starts with 4 and has 16 digits. 
 ● A MasterCard starts with 5 and has 16 digits. */

using System.Text.RegularExpressions;

public class ValidateCreditCard
{
    public static void Validate(string cardNumber)
    {
        string visaPattern = @"^4\d{15}$";
        string masterCardPattern = @"^5\d{15}$";

        if (Regex.IsMatch(cardNumber, visaPattern))
        {
            Console.WriteLine($"{cardNumber} is a valid Visa card");
        }
        else if (Regex.IsMatch(cardNumber, masterCardPattern))
        {
            Console.WriteLine($"{cardNumber} is a valid MasterCard");
        }
        else
        {
            Console.WriteLine($"{cardNumber} is an invalid or unsupported card type");
        }
    }
}
