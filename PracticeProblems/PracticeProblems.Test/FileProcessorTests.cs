using NUnit.Framework;
using PracticeProblems.App;
using System.IO;

namespace PracticeProblems.Test
{
    [TestFixture]
    public class FileProcessorTests// Unit tests for the FileProcessor class
    {
        private FileProcessor fileProcessor;
        private string testFile = "test.txt";

        [SetUp]
        public void Setup()
        {
            fileProcessor = new FileProcessor();
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(testFile))
            {
                File.Delete(testFile);
            }
        }

        [Test]
        public void WriteAndRead_ShouldWorkCorrectly()
        {
            string content = "Hello File!";
            fileProcessor.WriteToFile(testFile, content);
            
            string result = fileProcessor.ReadFromFile(testFile);
            
            Assert.That(result, Is.EqualTo(content));
        }

        [Test]
        public void WriteToFile_ShouldCreateFile()
        {
            fileProcessor.WriteToFile(testFile, "test");
            
            Assert.That(File.Exists(testFile), Is.True);
        }

        [Test]
        public void ReadFromFile_WhenFileDoesNotExist_ShouldThrowException()
        {
            Assert.Throws<FileNotFoundException>(() => fileProcessor.ReadFromFile("nonexistent.txt"));
        }
    }
}
