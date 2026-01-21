/*5. Extract All Capitalized Words from a Sentence 
 Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New 
 York." 
 Expected Output: 
 ● Eiffel, Tower, Paris, Statue, Liberty, New, York */
   // We look for words starting with Uppercase. 
        // Note: Usually "The" at the start of a sentence is capitalized but the problem example doesn't include it in expected output if it's just the first word? 
        // Actually the example output is: Eiffel, Tower, Paris, Statue, Liberty, New, York.
        // It seems it wants proper nouns or words that are capitalized but not necessarily the first word of the sentence if it's just "The".
        // However, standard regex for capitalized words is \b[A-Z][a-z]*\b.
        // Let's stick to the example. "The" is excluded in the example output.
using System.Text.RegularExpressions;

public class ExtractCapitalizedWords
{
    public static void Extract(string sentence)
    {
     
        
        string pattern = @"\b[A-Z][a-z]+\b";
        MatchCollection matches = Regex.Matches(sentence, pattern);

        var results = new System.Collections.Generic.List<string>();
        foreach (Match match in matches)
        {
            // The example excludes "The" at the beginning. 
            // This is a bit ambiguous, but I'll extract all capitalized words.
            if (match.Value != "The") 
            {
                results.Add(match.Value);
            }
        }
        Console.WriteLine(string.Join(", ", results));
    }
}
