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
    public partial class editFormPalaumovDA : Form
    {
        private DataTable table = new DataTable();
        public editFormPalaumovDA()
        {
            InitializeComponent();
        }

        private void editFormPalaumovDA_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files|*.csv|All Files|*.*";
        }

        private void buttonOpenPalaumovDA_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

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

                    // Устанавливаем таблицу данных в источник данных для DataGridView
                    dataGridViewEditPalaumovDA.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии CSV файла: " + ex.Message);
                }
            }
        }

        private void buttonSavePalaumovDA_Click(object sender, EventArgs e)
        {
            if (dataGridViewEditPalaumovDA.DataSource != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;

                    try
                    {
                        // Записываем данные в CSV файл
                        using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.GetEncoding("windows-1251")))
                        {
                            // Записываем заголовки столбцов
                            StringBuilder header = new StringBuilder();
                            foreach (DataColumn col in table.Columns)
                            {
                                header.Append(col.ColumnName + ",");
                            }
                            sw.WriteLine(header.ToString().Trim(','));

                            // Записываем данные
                            foreach (DataRow row in table.Rows)
                            {
                                StringBuilder line = new StringBuilder();
                                foreach (var item in row.ItemArray)
                                {
                                    line.Append(item.ToString() + ",");
                                }
                                sw.WriteLine(line.ToString().Trim(','));
                            }
                        }

                        MessageBox.Show("CSV файл успешно сохранен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении CSV файла: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.");
            }
        }
        private void buttonCloselPalaumovDA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}