using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomGen
{
    public partial class FormRand : Form
    {
        public FormRand()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(maskedTextBoxMin.Text);
                int y = Convert.ToInt32(maskedTextBoxMax.Text);
            if ((x - y) < 0)
            {
                Random rnd1 = new Random();
                int rndout = rnd1.Next(x, y);
                textBoxRez.Text = "Сгенерированное число: " + Convert.ToString(rndout);
            }
            else
            {
                string msg = "Максимальное число меньше минимального!";
              MessageBox.Show(msg, "Внимание !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните все исходные данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRand_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Вы действительно хотите выйти ?";
            DialogResult result = MessageBox.Show(msg,
            "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }
    }
}
