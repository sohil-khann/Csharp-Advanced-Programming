namespace PracticeProblems.App;

using System.Globalization;

public class DateFormatter // Class for formatting dates
{
    public string FormatDate(string inputDate)// Method to format date from "yyyy-MM-dd" to "dd-MM-yyyy"
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date.ToString("dd-MM-yyyy");
        }
        
        throw new ArgumentException("Invalid date format. Expected yyyy-MM-dd.");
    }
}
