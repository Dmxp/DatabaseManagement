using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PalaumovDA.Task1.V5
{
    public partial class PostavshikiPalaumovDA : Form
    {
        private DataTable table = new DataTable();
        public PostavshikiPalaumovDA()
        {
            InitializeComponent();
        }

        private void Postavshiki_Load(object sender, EventArgs e)
        {
            string filePath = "postavka.csv";

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

                dataGridViewPostavkaPalaumovDA.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из CSV файла: " + ex.Message);
            }
        }

        private void buttonClosethisPalaumovDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAllPPalaumovDA_Click(object sender, EventArgs e)
        {
            dataGridViewPostavkaPalaumovDA.DataSource = table;
        }

        private void buttonSearcPalaumovDA_Click(object sender, EventArgs e)
        {
            string productName = textBoxPostPalaumovDA.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Введите название товара для поиска");
                return;
            }

            var filteredRows = table.AsEnumerable()
                                     .Where(row => row.Field<string>(" Название поставщика").Contains(productName))
                                     .ToList();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Такого товара не найдено");
            }
            else
            {
                DataTable filteredTable = filteredRows.CopyToDataTable();
                dataGridViewPostavkaPalaumovDA.DataSource = filteredTable;
            }
        }
    }
}
