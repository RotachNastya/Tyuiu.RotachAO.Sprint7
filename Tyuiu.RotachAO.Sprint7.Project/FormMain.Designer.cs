namespace Tyuiu.RotachAO.Sprint7.Project
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnSaveCsv;
        private System.Windows.Forms.Button btnLoadCsv;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridView dgvEmployees;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.SplitContainer panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSaveCsv = new Button();
            btnLoadCsv = new Button();
            btnAddContract = new Button();
            btnAddEmployee = new Button();
            dgvContracts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dgvEmployees = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            panelTop = new Panel();
            panelButtons = new Panel();
            buttonHelp = new Button();
            panelMain = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelTop.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelMain).BeginInit();
            panelMain.Panel1.SuspendLayout();
            panelMain.Panel2.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSaveCsv
            // 
            btnSaveCsv.BackColor = Color.FromArgb(0, 123, 255);
            btnSaveCsv.FlatStyle = FlatStyle.Flat;
            btnSaveCsv.Font = new Font("Segoe UI", 9F);
            btnSaveCsv.ForeColor = Color.White;
            btnSaveCsv.Location = new Point(20, 10);
            btnSaveCsv.Name = "btnSaveCsv";
            btnSaveCsv.Size = new Size(170, 40);
            btnSaveCsv.TabIndex = 4;
            btnSaveCsv.Text = "💾 Сохранить";
            btnSaveCsv.UseVisualStyleBackColor = true;
            btnSaveCsv.Click += BtnSaveCsv_Click;
            // 
            // btnLoadCsv
            // 
            btnLoadCsv.BackColor = Color.FromArgb(0, 123, 255);
            btnLoadCsv.FlatStyle = FlatStyle.Flat;
            btnLoadCsv.Font = new Font("Segoe UI", 9F);
            btnLoadCsv.ForeColor = Color.White;
            btnLoadCsv.Location = new Point(190, 10);
            btnLoadCsv.Name = "btnLoadCsv";
            btnLoadCsv.Size = new Size(170, 40);
            btnLoadCsv.TabIndex = 5;
            btnLoadCsv.Text = "📂 Загрузить";
            btnLoadCsv.UseVisualStyleBackColor = true;
            btnLoadCsv.Click += BtnLoadCsv_Click;
            // 
            // btnAddContract
            // 
            btnAddContract.BackColor = Color.FromArgb(40, 167, 69);
            btnAddContract.FlatStyle = FlatStyle.Flat;
            btnAddContract.Font = new Font("Segoe UI", 9F);
            btnAddContract.ForeColor = Color.White;
            btnAddContract.Location = new Point(20, 10);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(170, 40);
            btnAddContract.TabIndex = 2;
            btnAddContract.Text = "➕ Добавить: Договор";
            btnAddContract.UseVisualStyleBackColor = true;
            btnAddContract.Click += BtnAddContract_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(40, 167, 69);
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI", 9F);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(190, 10);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(170, 40);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "➕ Добавить: Работника";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += BtnAddEmployee_Click;
            // 
            // dgvContracts
            // 
            dgvContracts.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvContracts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContracts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContracts.Dock = DockStyle.Top;
            dgvContracts.Location = new Point(10, 10);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(880, 180);
            dgvContracts.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Шифр договора";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Наименование организации";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Сроки выполнения";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Сумма договора";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Вид договора";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Примечания";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dgvEmployees
            // 
            dgvEmployees.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvEmployees.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 117, 125);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.Dock = DockStyle.Top;
            dgvEmployees.Location = new Point(10, 10);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(880, 180);
            dgvEmployees.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Номер";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "ФИО";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Адрес";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Телефон";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Должность";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Оклад";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Сроки работы";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(240, 240, 240);
            panelTop.Controls.Add(btnAddContract);
            panelTop.Controls.Add(btnAddEmployee);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 70);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 80);
            panelTop.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(233, 236, 239);
            panelButtons.Controls.Add(buttonHelp);
            panelButtons.Controls.Add(btnSaveCsv);
            panelButtons.Controls.Add(btnLoadCsv);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(900, 70);
            panelButtons.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp.Location = new Point(819, 11);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(69, 53);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 150);
            panelMain.Name = "panelMain";
            panelMain.Orientation = Orientation.Horizontal;
            // 
            // panelMain.Panel1
            // 
            panelMain.Panel1.Controls.Add(dgvContracts);
            panelMain.Panel1.Padding = new Padding(10);
            panelMain.Panel1.Text = "Contracts";
            // 
            // panelMain.Panel2
            // 
            panelMain.Panel2.Controls.Add(dgvEmployees);
            panelMain.Panel2.Padding = new Padding(10);
            panelMain.Panel2.Text = "Employees";
            panelMain.Size = new Size(900, 450);
            panelMain.SplitterDistance = 225;
            panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(900, 600);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelButtons);
            Name = "FormMain";
            Text = "Управление контрактами";
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panelTop.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            panelMain.Panel1.ResumeLayout(false);
            panelMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelMain).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private Button buttonHelp;
    }
}
