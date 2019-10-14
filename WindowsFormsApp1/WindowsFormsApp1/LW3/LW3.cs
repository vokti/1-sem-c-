using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.LW3
{
    public partial class LW3 : Form
    {
        public LW3()
        {
            InitializeComponent();
        }
        
        const double  g = 9.8;
        static double Vis(double y0, double v0, double t)
        {
            return y0 + v0 * t - g * t * t / 2;
        }
        public Tuple<double,double,double> Input(double args)
        {
            double y0 = Convert.ToDouble(textBox1.Text);
            double v0 = Convert.ToDouble(textBox2.Text);
            double t = Convert.ToDouble(textBox3.Text);
            return Tuple.Create(y0,v0,t);
        }
        public double output(double y)
        {
            textBox4.Text = Convert.ToString(y);
            return 1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Tuple<double,double,double> ind = Input(1);
            output(Vis(ind.Item1,ind.Item2,ind.Item3));
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form url = new LW3title();
            url.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
