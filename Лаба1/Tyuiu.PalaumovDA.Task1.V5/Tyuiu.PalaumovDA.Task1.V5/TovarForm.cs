using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Linq;

namespace Tyuiu.PalaumovDA.Task1.V5
{
    public partial class TovarFormPalaumovDA : Form
    {
        private DataTable table = new DataTable();

        public TovarFormPalaumovDA()
        {
            InitializeComponent();
        }

        private void TovarForm_Load(object sender, EventArgs e)
        {
            string filePath = "tovar.csv";

            try
            {
                Encoding encoding = Encoding.GetEncoding("windows-1251");
                using (StreamReader sr = new StreamReader(filePath, encoding))
                {
                    string line;

                    // Парсим заголовки столбцов из первой строки
                    if ((line = sr.ReadLine()) != null)
                    {
                        string[] headers = line.Split(',');
                        foreach (string header in headers)
                        {
                            table.Columns.Add(header);
                        }
                    }

                    // Парсим данные из остальных строк
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        table.Rows.Add(data);
                    }
                }

                dataGridViewTovarPalaumovDA.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из CSV файла: " + ex.Message);
            }
        }

        private void buttonSearchProductPalaumovDA_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductNamePalaumovDA.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Введите название товара для поиска");
                return;
            }

            var filteredRows = table.AsEnumerable()
                                     .Where(row => row.Field<string>(" Название товара").Contains(productName))
                                     .ToList();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Такого товара не найдено");
            }
            else
            {
                DataTable filteredTable = filteredRows.CopyToDataTable();
                dataGridViewTovarPalaumovDA.DataSource = filteredTable;
            }
        }

        private void buttonAllPalaumovDA_Click(object sender, EventArgs e)
        {
            dataGridViewTovarPalaumovDA.DataSource = table;
        }

        private void buttonClosePalaumovDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

