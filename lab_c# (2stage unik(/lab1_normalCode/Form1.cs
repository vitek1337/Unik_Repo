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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание 1 \n" +
                "подсчет площади треугольника (необходимо ввести длины всех сторон)",
                "О задаче",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задача 2 \n" +
                "Решение квадратного уравнения \n" +
                "необходимо ввести a, b и c",
                "О задаче",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задача 3 \n" +
                "преобразует числовое значение в слова",
                "О задаче",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
