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
    public partial class Form2 : Form
    {
        double z, x, b, a, y;
        public Form2()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = new LW1title();
            f1.Show();
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            x = double.Parse(textBox3.Text);
            y = Math.Sin(Math.Pow(Math.Pow(x, 2) + a,2));
            z = Math.Pow(x, 2) / a + Math.Cos(Math.Pow(x + b, 3));
            textBox5.Text = "y=" + Convert.ToString(y);
            textBox4.Text = "z=" + Convert.ToString(z);
            TextBox sbyt = textBox5;
            textBox4.Show();
            sbyt.Show();
        }


    }
}
