using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vvod(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        void vivod(TextBox t, double c)
        {
            t.Text = Convert.ToString(c);
        }
        
        static double rvg(double x)
        {
            return 180 * x / Math.PI;
        }

        static void tu(double a, double b, double c,ref double ua, ref double ub, ref double uc)
        {
            ua = ugol(a, b, c);
            ub = ugol(b, a, c);
            uc = ugol(c, b, a);

        }
        static double ugol(double a, double b,double c)
        {
            double aa;
            aa = (b * b + c * c - a * a) / (2 * b * c);
            aa = Math.Acos(aa);
            aa = rvg(aa);
            return aa;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = vvod(textBox1);
            b = vvod(textBox2);
            c = vvod(textBox3);
            double ua = 0, ub = 0, uc = 0;
            tu(a, b, c, ref ua, ref ub, ref uc);
            vivod(textBox4, ua);
            vivod(textBox5, ub);
            vivod(textBox6, uc);
        }
    }
}
