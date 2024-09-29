using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;  // Минимальное значение
            trackBar1.Maximum = 1000; // Максимальное значение
            trackBar1.Value = 50;   // Начальное значение
            trackBar1.TickFrequency = 10; // Частота отметок
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Solves solve = new Solves();
            label1.Text = "Epsilon = " + (trackBar1.Value / 10000.0);
            label2.Text = "= " + solve.row(trackBar1.Value / 10000.0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
