using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.RotachAO.Sprint7.Project.Lib;

namespace Tyuiu.RotachAO.Sprint7.Project
{
    public partial class FormMain : Form
    {
        private DataService _dataService;


        public FormMain()
        {
            InitializeComponent();

            // Initialize DataService with a directory path
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            _dataService = new DataService(dataDirectory);

            // Set up DataGridViews
            InitializeGridView(dgvContracts, new[] { "Шифр договора", "Наименование организации", "Сроки выполнения", "Сумма договора", "Примечания", "Вид договора" });
            InitializeGridView(dgvEmployees, new[] { "Номер", "ФИО", "Адрес", "Телефон", "Должность", "Оклад", "Сроки работы" });
        }

        private void InitializeGridView(DataGridView gridView, string[] columns)
        {
            gridView.Columns.Clear();
            foreach (var column in columns)
            {
                gridView.Columns.Add(column, column);
            }
        }

        private void BtnSaveCsv_Click(object sender, EventArgs e)
        {
            try
            {
                // Save Contracts
                var contractsData = GetDataFromGridView(dgvContracts);
                _dataService.SaveFromDataGridView("contracts.csv", contractsData);

                // Save Employees
                var employeesData = GetDataFromGridView(dgvEmployees);
                _dataService.SaveFromDataGridView("employees.csv", employeesData);

                MessageBox.Show("All data saved to CSV successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadCsv_Click(object sender, EventArgs e)
        {
            try
            {
                // Load Contracts
                if (_dataService.FileExists("contracts.csv"))
                {
                    var contractsData = _dataService.LoadFromCsv("contracts.csv")
                        .Select(row => row.ToList())
                        .ToList(); // Преобразуем в List<List<string>>
                    SetDataToGridView(dgvContracts, contractsData);
                }
                else
                {
                    MessageBox.Show("Contracts file not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Load Employees
                if (_dataService.FileExists("employees.csv"))
                {
                    var employeesData = _dataService.LoadFromCsv("employees.csv")
                        .Select(row => row.ToList())
                        .ToList(); // Преобразуем в List<List<string>>
                    SetDataToGridView(dgvEmployees, employeesData);
                }
                else
                {
                    MessageBox.Show("Employees file not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("All data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnAddContract_Click(object sender, EventArgs e)
        {
            dgvContracts.Rows.Add(); // Add a new row for contracts
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Add(); // Add a new row for employees
        }

        private void BtnArchiveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string archiveFolder = "Archive";
                _dataService.ArchiveFile("contracts.csv", archiveFolder);
                _dataService.ArchiveFile("employees.csv", archiveFolder);
                MessageBox.Show("Files archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error archiving files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void BtnLogActivity_Click(object sender, EventArgs e)
        {
            try
            {
                string logFileName = "activity.log";
                string message = $"User performed an action at {DateTime.Now}";
                _dataService.LogActivity(logFileName, message);
                MessageBox.Show("Activity logged successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging activity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<List<string>> GetDataFromGridView(DataGridView gridView)
        {
            var data = new List<List<string>>();

            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var rowData = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "").ToList();
                    data.Add(rowData);
                }
            }

            return data;
        }

        private void SetDataToGridView(DataGridView gridView, List<List<string>> data)
        {
            gridView.Rows.Clear();

            foreach (var row in data)
            {
                gridView.Rows.Add(row.ToArray());
            }
        }
    }
}
