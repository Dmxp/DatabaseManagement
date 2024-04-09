using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PalaumovDA.Task1.V5
{
    public partial class adminFormPalaumovDA : Form
    {
        public adminFormPalaumovDA()
        {
            InitializeComponent();
        }

        private void buttonLogPalaumovDA_Click(object sender, EventArgs e)
        {
            string login = textBoxLoginPalaumovDA.Text.Trim();
            string password = textBoxParolPAlaumovDA.Text.Trim();

            // Проверяем введенные данные
            if (login == "admin" && password == "admin")
            {
                // Открываем форму для редактирования CSV файла
                var editForm = new editFormPalaumovDA();
                editForm.Show();

                // Закрываем текущую форму
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
            }
        }
    }
}