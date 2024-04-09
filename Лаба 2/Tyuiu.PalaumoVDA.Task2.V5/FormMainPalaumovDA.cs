using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PalaumoVDA.Task2.V5
{
    public partial class FormMainPalaumovDA : Form
    {
        private OleDbConnection connection;
        //private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\msi\\source\\repos\\Tyuiu.PalaumoVDA.Task2.V5\\Tyuiu.PalaumoVDA.Task2.V5\\bin\\x64\\Debug\\Lab2_Palaumov_BD_Access_V5.accdb;Persist Security Info=False;";
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lab2_Palaumov_BD_Access_V5.accdb;Persist Security Info=False;";
        public FormMainPalaumovDA()
        {
            InitializeComponent();
        }
        private void FormMainPalaumovDA_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
            LoadTablesList();
            LoadQueriesList();
            buttonSearch_PDA.Click += buttonSearch_PDA_Click;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
//            string descriptionText = @"
//        Авиапассажирские перевозки представляют собой важную составляющую мировой инфраструктуры, обеспечивая связь между различными городами, странами и континентами. Этот сектор транспорта обеспечивает удобство, быстроту и безопасность пассажирских перевозок через воздушное пространство.
//";
//            richTextBoxPalaumovDA.Text = descriptionText;
//            richTextBoxPalaumovDA.SelectAll();
//            richTextBoxPalaumovDA.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void richTextBoxPalaumovDA_TextChanged(object sender, EventArgs e)
        {
            richTextBoxPalaumovDA.SelectionAlignment = HorizontalAlignment.Center;
        }
        //подключаем
        private void InitializeDatabase()
        {
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }
        private void LoadTablesList()
        {
            string[] allowedTables = { "Авиакомпания", "Пассажир", "Продажа", "Рейсы", "Самолеты" };

            DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            foreach (DataRow row in schemaTable.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                if (allowedTables.Contains(tableName))
                {
                    listBoxTablePDA.Items.Add(tableName);
                }
            }
        }
        private void buttonOpenTAble_PDA_Click(object sender, EventArgs e)
        {
            if (listBoxTablePDA.SelectedItem == null)
            {
                MessageBox.Show("Выберите таблицу для открытия.");
                return;
            }

            string selectedTable = listBoxTablePDA.SelectedItem.ToString();
            LoadTable(selectedTable);
        }
        private void LoadTable(string tableName)
        {
            string query = $"SELECT * FROM [{tableName}]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet, tableName);

            dataGridViewPalaumovDA.DataSource = dataSet.Tables[tableName];
        }
        private void buttonsaceChan_PDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewPalaumovDA.DataSource == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }
            string selectedTable = listBoxTablePDA.SelectedItem.ToString();
            SaveChanges(selectedTable);
        }
        private void SaveChanges(string tableName)
        {
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter($"SELECT * FROM [{tableName}]", connection);
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
                commandBuilder.QuotePrefix = "[";
                commandBuilder.QuoteSuffix = "]";
                commandBuilder.DataAdapter = dataAdapter;

                dataAdapter.Update((DataTable)dataGridViewPalaumovDA.DataSource);
                MessageBox.Show("Изменения сохранены успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        private void buttonClose_PDA_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void buttonExpWord_PDA_Click(object sender, EventArgs e)
        {
            ExportToWord();
        }
        private void ExportToWord()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Word Document (*.docx)|*.docx";
                saveDialog.FileName = "ExportedData.docx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    wordApp.Visible = false;

                    object missing = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    // Добавляем заголовки столбцов
                    for (int i = 0; i < dataGridViewPalaumovDA.Columns.Count; i++)
                    {
                        string headerText = dataGridViewPalaumovDA.Columns[i].HeaderText;
                        wordApp.Selection.TypeText(headerText);
                        wordApp.Selection.TypeText("\t");
                    }
                    wordApp.Selection.TypeParagraph();
                    // Добавляем данные
                    for (int i = 0; i < dataGridViewPalaumovDA.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewPalaumovDA.Columns.Count; j++)
                        {
                            object cellValue = dataGridViewPalaumovDA.Rows[i].Cells[j].Value;
                            string cellText = cellValue != null ? cellValue.ToString() : "";
                            wordApp.Selection.TypeText(cellText);
                            wordApp.Selection.TypeText("\t");
                        }
                        wordApp.Selection.TypeParagraph();
                    }
                    // Сохраняем документ и закрываем Word
                    object fileName = saveDialog.FileName;
                    wordDoc.SaveAs2(ref fileName);
                    wordApp.Quit();

                    MessageBox.Show("Данные успешно экспортированы в Word.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта данных в Word: {ex.Message}");
            }
        }
        private void buttonSaveEXC_PDA_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveDialog.FileName = "ExportedData.xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Visible = false;

                    Microsoft.Office.Interop.Excel.Workbook excelBook = excelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.ActiveSheet;

                    // Добавляем заголовки столбцов
                    for (int i = 0; i < dataGridViewPalaumovDA.Columns.Count; i++)
                    {
                        excelSheet.Cells[1, i + 1] = dataGridViewPalaumovDA.Columns[i].HeaderText;
                    }

                    // Добавляем данные
                    for (int i = 0; i < dataGridViewPalaumovDA.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewPalaumovDA.Columns.Count; j++)
                        {
                            excelSheet.Cells[i + 2, j + 1] = dataGridViewPalaumovDA.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    excelBook.SaveAs(saveDialog.FileName);
                    excelApp.Quit();

                    MessageBox.Show("Данные успешно экспортированы в Excel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта данных в Excel: {ex.Message}");
            }
        }

        private void buttonSavePDF_PDA_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }
        private void ExportToPDF()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveDialog.FileName = "ExportedData.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document();
                    iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new System.IO.FileStream(saveDialog.FileName, System.IO.FileMode.Create));

                    pdfDoc.Open();

                    // Добавляем заголовки столбцов
                    for (int i = 0; i < dataGridViewPalaumovDA.Columns.Count; i++)
                    {
                        pdfDoc.Add(new iTextSharp.text.Paragraph(dataGridViewPalaumovDA.Columns[i].HeaderText));
                    }
                    pdfDoc.Add(new iTextSharp.text.Paragraph("\n"));

                    // Добавляем данные
                    for (int i = 0; i < dataGridViewPalaumovDA.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewPalaumovDA.Columns.Count; j++)
                        {
                            pdfDoc.Add(new iTextSharp.text.Paragraph(dataGridViewPalaumovDA.Rows[i].Cells[j].Value?.ToString()));
                        }
                        pdfDoc.Add(new iTextSharp.text.Paragraph("\n"));
                    }

                    pdfDoc.Close();

                    MessageBox.Show("Данные успешно экспортированы в PDF.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта данных в PDF: {ex.Message}");
            }
        }

        private void buttonSaveCSV_PDA_Click(object sender, EventArgs e)
                    {
                        ExportToCSV();
                    }

        private void ExportToCSV()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV (*.csv)|*.csv";
                saveDialog.FileName = "ExportedData.csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveDialog.FileName))
                    {
                        // Добавляем заголовки столбцов
                        for (int i = 0; i < dataGridViewPalaumovDA.Columns.Count; i++)
                        {
                            sw.Write(dataGridViewPalaumovDA.Columns[i].HeaderText);
                            if (i < dataGridViewPalaumovDA.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        // Добавляем данные
                        for (int i = 0; i < dataGridViewPalaumovDA.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewPalaumovDA.Columns.Count; j++)
                            {
                                sw.Write(dataGridViewPalaumovDA.Rows[i].Cells[j].Value?.ToString());
                                if (j < dataGridViewPalaumovDA.Columns.Count - 1)
                                {
                                    sw.Write(",");
                                }
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Данные успешно экспортированы в CSV.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта данных в CSV: {ex.Message}");
            }
        }
        private void LoadQueriesList()
        {
            string[] queries = {
                "Инфо самолеты",
                "Кол-во билетов проданных авиакомпанией",
                "Пассажир вылет",
                "Пассажиры самолета",
                "Продажа билетов",
                "Рейсы Авиакомпаний",
                "Рейсы с информацией о самолете",
                "Самолеты Авиакомпаний",
                "Стоимость билета пассажира"
            };

            listBoxZapros_PDA.Items.AddRange(queries);
        }
        private string GetQueryText(string queryName)
        {
            Dictionary<string, string> queries = new Dictionary<string, string>()
            {
                { "Инфо самолеты", "SELECT Авиакомпания.Название, Авиакомпания.Страна, Самолеты.Производитель, Самолеты.Модель, Самолеты.[Год выпуска] FROM Авиакомпания INNER JOIN Самолеты ON Авиакомпания.id = Самолеты.id_airline;" },
                { "Кол-во билетов проданных авиакомпанией", "SELECT Авиакомпания.Название, Продажа.[Кол-во билетов], Продажа.Стоимость FROM Авиакомпания INNER JOIN Продажа ON Авиакомпания.id = Продажа.id_airline;" },
                { "Пассажир вылет", "SELECT Пассажир.Имя, Пассажир.Фамилия, Рейсы.[Дата рейса], Рейсы.[Номер рейса], Рейсы.Время FROM (Авиакомпания INNER JOIN Пассажир ON Авиакомпания.id = Пассажир.id_airline) INNER JOIN Рейсы ON Авиакомпания.id = Рейсы.id_airline;" },
                { "Пассажиры самолета", "SELECT Самолеты.Модель, Самолеты.Производитель, Самолеты.[Год выпуска], Пассажир.Имя, Пассажир.Фамилия, Пассажир.[Дата рождения] FROM Самолеты INNER JOIN Пассажир ON Самолеты.id = Пассажир.id_plane;" },
                { "Продажа билетов", "SELECT Продажа.[Дата продажи], Продажа.Стоимость, Продажа.[Кол-во билетов] FROM Продажа;" },
                { "Рейсы Авиакомпаний", "SELECT Авиакомпания.Название, Рейсы.[Дата рейса], Рейсы.[Номер рейса], Рейсы.Время FROM Авиакомпания INNER JOIN Рейсы ON Авиакомпания.id = Рейсы.id_airline;" },
                { "Рейсы с информацией о самолете", "SELECT Самолеты.Модель, Самолеты.Производитель, Самолеты.[Год выпуска], Рейсы.[Дата рейса], Рейсы.[Номер рейса], Рейсы.Время FROM (Авиакомпания INNER JOIN Рейсы ON Авиакомпания.id = Рейсы.id_airline) INNER JOIN Самолеты ON Авиакомпания.id = Самолеты.id_airline;" },
                { "Самолеты Авиакомпаний", "SELECT Самолеты.Модель, Самолеты.Производитель, Авиакомпания.Название FROM Авиакомпания INNER JOIN Самолеты ON Авиакомпания.id = Самолеты.id_airline;" },
                { "Стоимость билета пассажира", "SELECT Пассажир.Имя, Пассажир.Фамилия, Продажа.Стоимость FROM Продажа INNER JOIN Пассажир ON Продажа.id = Пассажир.id_sale;" }
            };

            if (queries.ContainsKey(queryName))
            {
                return queries[queryName];
            }
            else
            {
                return "";
            }
        }
        private void listBoxZapros_PDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxZapros_PDA.SelectedItem != null)
            {
                string selectedQuery = listBoxZapros_PDA.SelectedItem.ToString();
                string selectedQueryText = GetQueryText(selectedQuery);
            }
        }

        private void buttonOpenZapr_PDA_Click(object sender, EventArgs e)
        {
            if (listBoxZapros_PDA.SelectedItem != null)
            {
                string selectedQuery = listBoxZapros_PDA.SelectedItem.ToString();
                string selectedQueryText = GetQueryText(selectedQuery);
                ExecuteQuery(selectedQueryText);
            }
            else
            {
                MessageBox.Show("Выберите запрос из списка.");
            }
        }
        private void ExecuteQuery(string query)
        {
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridViewPalaumovDA.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
        }

        private void buttonSearch_PDA_Click(object sender, EventArgs e)
        {
           
            string keyword = textBoxSearch_PDA.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Введите ключевое слово для поиска.");
                return;
            }

            DataTable dataTable = (DataTable)dataGridViewPalaumovDA.DataSource;
            if (dataTable == null)
            {
                MessageBox.Show("Нет данных для поиска.");
                return;
            }

            string filter = string.Join(" OR ", dataTable.Columns.Cast<DataColumn>()
                .Select(c => $"{c.ColumnName} LIKE '%{keyword}%'"));

            dataTable.DefaultView.RowFilter = filter;

            dataGridViewPalaumovDA.ClearSelection();

            textBoxSearch_PDA.Clear();
        }
    }
}
