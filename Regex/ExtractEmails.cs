/*4. Extract All Email Addresses from a Text 
 Example Text: "Contact us at support@example.com and info@company.org" 
 Expected Output: 
 ● support@example.com 
 ● info@company.org */

using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Extract(string text)
    {
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
