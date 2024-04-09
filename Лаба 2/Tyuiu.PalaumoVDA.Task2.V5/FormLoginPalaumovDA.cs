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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tyuiu.PalaumoVDA.Task2.V5
{
    public partial class FormLoginPalaumovDA : Form
    {
        public FormLoginPalaumovDA()
        {
            InitializeComponent();
        }

        private void buttonloginPalaumovDA_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginPalaumovDA.Text;
            string password = textBoxpassPalaumovDA.Text;

            AutoPalaumovDA auto = new AutoPalaumovDA();
            bool isValid = auto.ValidateUser(username, password);

            if (isValid)
            {
                MessageBox.Show("Авторизация успешна!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void buttonRegistr_PDA_Click(object sender, EventArgs e)
        {
            FormRegistration_PDA registrationForm = new FormRegistration_PDA();
            registrationForm.Show();
        }
    }
}

