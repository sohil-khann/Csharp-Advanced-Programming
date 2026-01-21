/*14. Find Repeating Words in a Sentence 
 Example Input: "This is is a repeated repeated word test." 
 Expected Output: 
 ● is, repeated */

using System.Text.RegularExpressions;

public class FindRepeatingWords
{
    public static void Find(string sentence)
    {
        // \b(\w+)\s+\1\b matches a word followed by itself
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(sentence, pattern);

        var results = new System.Collections.Generic.HashSet<string>();
        foreach (Match match in matches)
        {
            // The first capturing group is the word itself
            results.Add(match.Groups[1].Value);
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
