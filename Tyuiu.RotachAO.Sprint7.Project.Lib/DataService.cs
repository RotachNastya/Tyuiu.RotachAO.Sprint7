using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.RotachAO.Sprint7.Project.Lib
{
    public class DataService
    {
        private readonly string _directoryPath;

        public DataService(string directoryPath)
        {
            _directoryPath = directoryPath;
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        // Save data to CSV file
        public void SaveToCsv(string fileName, List<string[]> data)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var row in data)
                {
                    writer.WriteLine(string.Join(",", row));
                }
            }
        }

        // Load data from CSV file
        public List<string[]> LoadFromCsv(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            var result = new List<string[]>();

            if (!File.Exists(filePath))
                return result;

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        result.Add(line.Split(","));
                    }
                }
            }

            return result;
        }

        // Archive a file
        public void ArchiveFile(string fileName, string archiveFolder)
        {
            string sourcePath = Path.Combine(_directoryPath, fileName);
            string archivePath = Path.Combine(_directoryPath, archiveFolder);

            if (!Directory.Exists(archivePath))
            {
                Directory.CreateDirectory(archivePath);
            }

            string destinationPath = Path.Combine(archivePath, fileName);
            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
            }
        }

        // Log activity
        public void LogActivity(string logFileName, string message)
        {
            string logFilePath = Path.Combine(_directoryPath, logFileName);
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

            using (var writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }

        // Save data from DataGridView to CSV (assumed data is passed from the form)
        public void SaveFromDataGridView(string fileName, List<List<string>> data)
        {
            var csvData = data.Select(row => row.ToArray()).ToList();
            SaveToCsv(fileName, csvData);
        }

        // Add new data to CSV
        public void AddRowToCsv(string fileName, List<string> newRow)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(string.Join(",", newRow));
            }
        }

        // Remove row(s) from CSV by a specific column value
        public void RemoveRowsFromCsv(string fileName, int columnIndex, string value)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            if (!File.Exists(filePath))
                return;

            var data = LoadFromCsv(fileName);
            var filteredData = data.Where(row => row[columnIndex] != value).ToList();

            SaveToCsv(fileName, filteredData);
        }

        // Update row in CSV by a specific column value
        public void UpdateRowInCsv(string fileName, int columnIndex, string searchValue, List<string> newRow)
        {
            string filePath = Path.Combine(_directoryPath, fileName);

            if (!File.Exists(filePath))
                return;

            var data = LoadFromCsv(fileName);
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][columnIndex] == searchValue)
                {
                    data[i] = newRow.ToArray();
                }
            }

            SaveToCsv(fileName, data);
        }

        // Check if file exists
        public bool FileExists(string fileName)
        {
            string filePath = Path.Combine(_directoryPath, fileName);
            return File.Exists(filePath);
        }

        // Get default fields for file types
        public List<string> GetDefaultFields(string fileType)
        {
            return fileType switch
            {
                "contracts" => new List<string> { "Шифр договора", "Наименование организации", "Сроки выполнения", "Сумма договора", "Примечания", "Вид договора" },
                "employees" => new List<string> { "Номер", "ФИО", "Адрес", "Телефон", "Должность", "Оклад", "Сроки работы" },
                _ => new List<string>()
            };
        }
    }
}
