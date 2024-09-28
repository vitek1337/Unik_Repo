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
    public partial class Form3 : Form
    {
        checkType check1 = new checkType();
        Solve solves = new Solve();
        double a = 0, b = 0, c = 0;
        string SquareProblem;
        public Form3()
        {
            InitializeComponent();
            this.SquareProblem = "(a*x^2) + (b*x) + (c) = ?";
            label1.Text = this.SquareProblem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> list1 = new List<double>();
            bool OKValueFlag = true;
            if ((check1 as Icheck).check(textBox1.Text))
            {
                list1.Add(double.Parse(textBox1.Text));

            }
            else list1.Add(0);
            
            if ((check1 as Icheck).check(textBox2.Text)) list1.Add(double.Parse(textBox2.Text));
            else list1.Add(0);
            
            if ((check1 as Icheck).check(textBox3.Text)) list1.Add(double.Parse(textBox3.Text));
            else list1.Add(0);

            this.SquareProblem = $"({list1[0]})*x^2 + ({list1[1]})*x + ({list1[2]}) \n";
            if (OKValueFlag == true) label1.Text = this.SquareProblem + solves.SquareProblem(list1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
