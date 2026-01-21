using System;


// 1. Validate Username
Console.WriteLine("1. Validate Username:");
bool userResult = ValidateUsername.Validate("user_123");
Console.WriteLine($"user_123: {userResult}");
Console.WriteLine();

// 2. Validate Number Plate
Console.WriteLine("2. Validate Number Plate:");
ValidateNumberPlate.Validate("AB1234");
Console.WriteLine();

// 3. Validate Hex Color Code
Console.WriteLine("3. Validate Hex Color Code:");
ValidateHexColorCode.Validate("#FFA500");
ValidateHexColorCode.Validate("#ff4500");
ValidateHexColorCode.Validate("#123");
Console.WriteLine();

// 4. Extract Emails
Console.WriteLine("4. Extract Emails:");
ExtractEmails.Extract("Contact us at support@example.com and info@company.org");
Console.WriteLine();

// 5. Extract Capitalized Words
Console.WriteLine("5. Extract Capitalized Words:");
ExtractCapitalizedWords.Extract("The Eiffel Tower is in Paris and the Statue of Liberty is in New York.");
Console.WriteLine();

// 6. Extract Dates
Console.WriteLine("6. Extract Dates:");
ExtractDates.Extract("The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.");
Console.WriteLine();

// 7. Extract Links
Console.WriteLine("7. Extract Links:");
ExtractLinks.Extract("Visit https://www.google.com and http://example.org for more info.");
Console.WriteLine();

// 8. Replace Multiple Spaces
Console.WriteLine("8. Replace Multiple Spaces:");
ReplaceMultipleSpaces.Replace("This is  an  example   with   multiple    spaces.");
Console.WriteLine();

// 9. Censor Bad Words
Console.WriteLine("9. Censor Bad Words:");
CensorBadWords.Censor("This is a damn bad example with some stupid words.", new string[] { "damn", "stupid" });
Console.WriteLine();

// 10. Validate IP Address
Console.WriteLine("10. Validate IP Address:");
ValidateIPAddress.Validate("192.168.1.1");
ValidateIPAddress.Validate("256.0.0.1");
Console.WriteLine();

// 11. Validate Credit Card
Console.WriteLine("11. Validate Credit Card:");
ValidateCreditCard.Validate("4123456789012345"); // Visa
ValidateCreditCard.Validate("5123456789012345"); // MasterCard
Console.WriteLine();

// 12. Extract Languages
Console.WriteLine("12. Extract Languages:");
ExtractLanguages.Extract("I love Java, Python, and JavaScript, but I haven't tried Go yet.", new string[] { "Java", "Python", "JavaScript", "Go" });
Console.WriteLine();

// 13. Extract Currency
Console.WriteLine("13. Extract Currency:");
ExtractCurrency.Extract("The price is $45.99, and the discount is $ 10.50.");
Console.WriteLine();

// 14. Find Repeating Words
Console.WriteLine("14. Find Repeating Words:");
FindRepeatingWords.Find("This is is a repeated repeated word test.");
Console.WriteLine();

// 15. Validate SSN
Console.WriteLine("15. Validate SSN:");
ValidateSSN.Validate("123-45-6789");
ValidateSSN.Validate("123456789");
Console.WriteLine();
