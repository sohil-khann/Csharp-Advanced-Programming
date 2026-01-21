/*13. Extract Currency Values from a Text 
 Example Text: "The price is $45.99, and the discount is $ 10.50." 
 Expected Output: 
 ● $45.99, 10.50 */

using System.Text.RegularExpressions;

public class ExtractCurrency
{
    public static void Extract(string text)
    {
        // Pattern to match $ followed by optional space and digits with optional decimal part
        string pattern = @"\$\s?\d+(\.\d{2})?";
        MatchCollection matches = Regex.Matches(text, pattern);

        var results = new System.Collections.Generic.List<string>();
        foreach (Match match in matches)
        {
            
            results.Add(match.Value.Trim());
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
