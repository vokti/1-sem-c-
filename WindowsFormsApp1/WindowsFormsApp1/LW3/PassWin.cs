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
    public partial class PassWin : Form
    {
        public PassWin()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox3.Text == "admin"))
            {
                Form LW3a = new LW3();
                Form LW3t = new LW3title();
                LW3t.Close();
                LW3a.Show();
                timer1.Stop();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password or login");
            }
        }

        private void PassWin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Run out of time");
            Form Lw3t = new LW3title();
            Lw3t.Show();
            this.Close();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "No login");
            }
        }

        private void TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider2.SetError(textBox3, "No password");
            }
        }
    }
}
