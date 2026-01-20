/*8. Replace Multiple Spaces with a Single Space 
 Example Input: "This is  an  example   with   multiple    spaces." 
 Expected Output: "This is an example with multiple spaces." */

using System.Text.RegularExpressions;

public class ReplaceMultipleSpaces
{
    public static void Replace(string input)
    {
        string pattern = @"\s+";
        string result = Regex.Replace(input, pattern, " ");
        Console.WriteLine(result);
    }
}
