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
    public partial class LW1 : Form
    {
        double z, x, b, a, y;

        public LW1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Form f1 = new LW1title();
            f1.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                x = double.Parse(textBox3.Text);
                y = Math.Sin(Math.Pow(Math.Pow(x, 2) + a, 2));
                z = Math.Pow(x, 2) / a + Math.Cos(Math.Pow(x + b, 3));
                textBox5.Text = Convert.ToString(y);
                textBox4.Text = Convert.ToString(z);
                label4.Show();
                textBox5.Show();
                label5.Show();
                textBox4.Show();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Ошибка деления на 0");
            }
            catch
            {
                MessageBox.Show("Ошибка данных");
            }
        }


    }
}
