/*9. Censor Bad Words in a Sentence 
 Given a list of bad words, replace them with ****. 
 Example Input: "This is a damn bad example with some stupid words." 
 Expected Output: "This is a **** bad example with some **** words." */

using System.Text.RegularExpressions;

public class CensorBadWords
{
    public static void Censor(string sentence, string[] badWords)
    {
        // Join bad words with | for regex alternation
        string pattern = @"\b(" + string.Join("|", badWords) + @")\b";
        string result = Regex.Replace(sentence, pattern, "****", RegexOptions.IgnoreCase);
        Console.WriteLine(result);
    }
}
