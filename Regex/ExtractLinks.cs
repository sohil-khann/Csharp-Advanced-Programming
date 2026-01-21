/*7. Extract Links from a Web Page 
 Example Text: "Visit https://www.google.com and http://example.org for more 
 info." 
 Expected Output: 
 ● https://www.google.com, http://example.org */

using System.Text.RegularExpressions;

public class ExtractLinks
{
    public static void Extract(string text)
    {
        string pattern = @"https?://[^\s]+";
        MatchCollection matches = Regex.Matches(text, pattern);

        var results = new System.Collections.Generic.List<string>();
        foreach (Match match in matches)
        {
            results.Add(match.Value);
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
