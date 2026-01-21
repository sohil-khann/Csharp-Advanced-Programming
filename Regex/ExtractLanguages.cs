/*12. Extract Programming Language Names from a Text 
 Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet." 
 Expected Output: 
 ● Java, Python, JavaScript, Go */

using System.Text.RegularExpressions;

public class ExtractLanguages
{
    public static void Extract(string text, string[] languages)
    {
        // Construct pattern based on provided language list
        string pattern = @"\b(" + string.Join("|", languages) + @")\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        var results = new System.Collections.Generic.List<string>();
        foreach (Match match in matches)
        {
            results.Add(match.Value);
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
