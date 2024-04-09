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
    public partial class MainFormPalaumovDA : Form
    {
        public MainFormPalaumovDA()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonTovarPalaumovDA_Click(object sender, EventArgs e)
        {
            var tovarForm = new TovarFormPalaumovDA();
            tovarForm.Show();
        }

        private void buttonPostavshikiPalaumovDA_Click(object sender, EventArgs e)
        {
            var Postavshiki = new PostavshikiPalaumovDA();
            Postavshiki.Show();
        }

        private void buttonOtzuvPalaumovDA_Click(object sender, EventArgs e)
        {
            var Otzuv= new OtzuvPalaumovDA();
            Otzuv.Show();
        }

        private void buttonAdminPalaumovDA_Click(object sender, EventArgs e)
        {
            var adminForm = new adminFormPalaumovDA();
            adminForm.Show();
        }

        private void buttonCloseMainPalaumovDA_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
