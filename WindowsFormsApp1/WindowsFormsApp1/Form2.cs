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
        double x, y, b, a,answ;
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
            Form f1 = new title();
            f1.Show();
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToDouble(Console.ReadLine());
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            y = Convert.ToDouble(Console.ReadLine());
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
             a = Convert.ToDouble(Console.ReadLine());
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Console.ReadLine());
            answ = a + b + x + y;
            comboBox1.Text=
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ComboBox sbyt = comboBox1;
            sbyt.Show();
        }


    }
}
