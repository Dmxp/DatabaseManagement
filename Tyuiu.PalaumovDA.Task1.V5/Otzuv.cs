using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Tyuiu.PalaumovDA.Task1.V5
{
    public partial class OtzuvPalaumovDA : Form
    {
        private string filePath = "otzuv.csv";

        public OtzuvPalaumovDA()
        {
            InitializeComponent();
        }

        private void buttonSendPalaumovDA_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIOPalaumovDA.Text.Trim();
            string phoneNumber = textBoxPnoneNumPalaumovDA.Text.Trim();
            string email = textBoxEmailPalaumovDA.Text.Trim();
            string review = richTextBoxOtzPalaumovDA.Text.Trim();

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(review))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                // Создаем строку для записи в файл
                string newLine = $"{fio},{phoneNumber},{email},{review}";

                // Добавляем новую строку в CSV файл с указанием windows-1251 кодировки
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("windows-1251")))
                {
                    sw.WriteLine(newLine);
                }

                MessageBox.Show("Отзыв успешно отправлен и сохранен в файл.");

                // Очищаем поля после отправки
                textBoxFIOPalaumovDA.Text = "";
                textBoxPnoneNumPalaumovDA.Text = "";
                textBoxEmailPalaumovDA.Text = "";
                richTextBoxOtzPalaumovDA.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении отзыва в файл: " + ex.Message);
            }
            this.Close();
        }
    }
}