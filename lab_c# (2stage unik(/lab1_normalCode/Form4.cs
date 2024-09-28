using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_normalCode
{
    public partial class Form4 : Form
    {
        checkType check1 = new checkType();
        Solve solve1 = new Solve();

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;

            if ((check1 as Icheck).check(textBox1.Text))
            {
                value = (int.Parse(textBox1.Text));
                label1.Text = $"{value} словами = {solve1.NumberToWords(value)}";
            }
            else
            {
                MessageBox.Show(
                "Данные введены неверно",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
