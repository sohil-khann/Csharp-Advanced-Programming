/*10. Validate an IP Address 
 A valid IPv4 address consists of four groups of numbers (0-255) separated by 
 dots. */

using System.Text.RegularExpressions;

public class ValidateIPAddress
{
    public static void Validate(string ip)
    {
        // Pattern for 0-255: 
        // 25[0-5] | 2[0-4][0-9] | [01]?[0-9][0-9]?
        string octet = @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
        string pattern = $@"^{octet}\.{octet}\.{octet}\.{octet}$";

        if (Regex.IsMatch(ip, pattern))
        {
            Console.WriteLine($"{ip} is a valid IPv4 address");
        }
        else
        {
            Console.WriteLine($"{ip} is an invalid IPv4 address");
        }
    }
}
