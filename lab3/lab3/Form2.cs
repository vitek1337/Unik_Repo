using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        bool hideFlag = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Solves solve = new Solves();
            label1.Text = "X = " + (trackBar1.Value);
            label2.Text = " = " + solve.CalculateFunction(trackBar1.Value);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;  // Минимальное значение
            trackBar1.Maximum = 3; // Максимальное значение
            trackBar1.Value = 1;   // Начальное значение
            trackBar1.TickFrequency = 1; // Частота отметок
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solves solve = new Solves();

            if (this.hideFlag == false)
            {
                HideAll();
                button1.Text = "Назад";
                label2.Text = " = " + solve.task_5();
                label5.Text = "(сумма значений на отрезке [1;3]";
                this.hideFlag = true;
                solve.task_5();
            }
            else {
                this.hideFlag = false;
                ShowAll();
                label2.Text = " = " + solve.CalculateFunction(trackBar1.Value);
            }
        }

        private void HideAll()
        {
            label1.Hide();
            trackBar1.Hide();
            label3.Hide();
            label4.Hide();
            label5.Show();
        }

        private void ShowAll()
        {
            label1.Show();
            pictureBox1.Show();
            label5.Hide();
            trackBar1.Show();
            label3.Show();
            label4.Show();
            button1.Text = "Показать сумму значений на отрезке [1;3]";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
