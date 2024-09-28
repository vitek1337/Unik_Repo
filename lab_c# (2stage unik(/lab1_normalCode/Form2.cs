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
    public partial class Form2 : Form
    {
        checkType check1 = new checkType();
        Solve solves = new Solve();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string label1Text;
            label1Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> list1 = new List<double>();
            bool OKValueFlag = true;
            if ((check1 as Icheck).check(textBox1.Text)) list1.Add(double.Parse(textBox1.Text));
            if ((check1 as Icheck).check(textBox2.Text)) list1.Add(double.Parse(textBox2.Text));
            if ((check1 as Icheck).check(textBox3.Text)) list1.Add(double.Parse(textBox3.Text));
            
            if (list1.Count == 3) {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        if (list1[i] < 0)
                        {
                            MessageBox.Show(
                            "стороны треугольника могут быть только положительными",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                            OKValueFlag = false;
                            break;
                        };
                    }
                    if (OKValueFlag == true) label4.Text = label4.Text + Math.Round(solves.Square(list1), 2); 
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
