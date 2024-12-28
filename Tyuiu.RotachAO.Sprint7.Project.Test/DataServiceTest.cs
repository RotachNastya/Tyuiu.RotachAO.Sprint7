using System.IO;
using NUnit.Framework;
using Tyuiu.RotachAO.Sprint7.Project.Lib;

namespace Tyuiu.RotachAO.Sprint7.Project.Test
{
    public class Tests
    {
        private string _testDirectory;
        private DataService _dataService;

        [SetUp]
        public void SetUp()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), "DataServiceTests");
            Directory.CreateDirectory(_testDirectory);
            _dataService = new DataService(_testDirectory);
        }

        [TearDown]
        public void TearDown()
        {
            if (Directory.Exists(_testDirectory))
            {
                Directory.Delete(_testDirectory, true);
            }
        }

        [Test]
        public void LogActivity_ShouldCreateLogFileAndAppendEntry()
        {
            // Arrange
            string logFileName = "activity.log";
            string testMessage = "Test log message";

            // Act
            _dataService.LogActivity(logFileName, testMessage);

            // Assert
            string logFilePath = Path.Combine(_testDirectory, logFileName);
            Assert.IsTrue(File.Exists(logFilePath), "Log file should exist.");
            string logContent = File.ReadAllText(logFilePath);
            Assert.IsTrue(logContent.Contains(testMessage), "Log file should contain the log message.");
        }
    }
}
