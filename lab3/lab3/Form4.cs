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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Solves solve = new Solves();

            label1.Text = $"= {solve.task_8(trackBar1.Value)}";
            label2.Text = trackBar1.Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;  // Минимальное значение
            trackBar1.Maximum = 230; // Максимальное значение
            trackBar1.Value = 1;   // Начальное значение
            trackBar1.TickFrequency = 1; // Частота отметок
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
