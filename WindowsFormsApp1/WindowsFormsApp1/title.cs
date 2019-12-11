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
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form f2 = new LW1title();
            f2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Form po = new exit();
            po.Show();
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form LW3q = new LW3.LW3title();
            LW3q.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form LW3t = new LW4.LW4title();
            LW3t.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form x = new LW5.LW5title();
            x.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form y = new LW6.LW6();
            y.Show();
            this.Hide();
        }
    }
}
