/*3. Validate a Hex Color Code 
 A valid hex color: 
 ● Starts with a # 
 ● Followed by 6 hexadecimal characters (0-9, A-F, a-f). 
 Example Inputs & Outputs: 
 ●  "#FFA500" → Valid 
 ●  "#ff4500" → Valid 
 ●  "#123" → Invalid (too short) */

using System.Text.RegularExpressions;

public class ValidateHexColorCode
{
    public static void Validate(string hex)
    {
        string pattern = @"^#[0-9a-fA-F]{6}$";
        if (Regex.IsMatch(hex, pattern))
        {
            Console.WriteLine($"{hex} is Valid");
        }
        else
        {
            Console.WriteLine($"{hex} is Invalid");
        }
    }
}
