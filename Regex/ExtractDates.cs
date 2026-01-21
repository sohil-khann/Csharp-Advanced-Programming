/*6. Extract Dates in dd/mm/yyyy Format 
 Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020." 
 Expected Output: 
 ● 12/05/2023, 15/08/2024, 29/02/2020 */

using System.Text.RegularExpressions;

public class ExtractDates
{
    public static void Extract(string text)
    {
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        var results = new System.Collections.Generic.List<string>();
        foreach (Match match in matches)
        {
            results.Add(match.Value);
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
