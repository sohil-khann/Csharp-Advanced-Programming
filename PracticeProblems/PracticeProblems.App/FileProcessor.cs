using System;
using System.IO;

namespace PracticeProblems.App// Class for processing file read and write operations
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content) // Method to write content to a file
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The file does not exist.");
            }
            return File.ReadAllText(filename);
        }
    }
}
