using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PalaumoVDA.Task2.V5
{
    internal class AutoPalaumovDA
    {
        //private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\msi\\source\\repos\\Tyuiu.PalaumoVDA.Task2.V5\\Tyuiu.PalaumoVDA.Task2.V5\\bin\\x64\\Debug\\Lab2_Palaumov_BD_Access_V5.accdb;Persist Security Info=False;";
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lab2_Palaumov_BD_Access_V5.accdb;Persist Security Info=False;";

        public bool ValidateUser(string username, string password)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Count(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
