using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PalaumoVDA.Task2.V5
{
    public partial class FormRegistration_PDA : Form
    {
        public FormRegistration_PDA()
        {
            InitializeComponent();
        }

        private void FormRegistration_PDA_Load(object sender, EventArgs e)
        {

        }

        private void buttonRigistration_PDA_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin_PDA.Text;
            string password = textBoxPass_PDA.Text;
            string confirmPassword = textBoxPassPass_PDA.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, введите пароль и его подтверждение еще раз.", "Ошибка");
                return;
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lab2_Palaumov_BD_Access_V5.accdb;Persist Security Info=False;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Username, [Password]) VALUES (?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", login);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь зарегистрирован успешно.", "Успех");
                            textBoxLogin_PDA.Text = "";
                            textBoxPass_PDA.Text = "";
                            textBoxPassPass_PDA.Text = "";
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось зарегистрировать пользователя.", "Ошибка");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка регистрации пользователя: {ex.Message}", "Ошибка");
                }
            }
        }
       
    }
}
