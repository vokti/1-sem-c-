using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LWlib;

namespace WindowsFormsApp1.LW6
{
    public partial class LW6 : Form
    {
        public LW6()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LW6c LW = new LW6c();
            VV V = new VV();
            double[] q = LW.Ex(dataGridView1, V.Vvod(textBox1), V.Vvod(textBox2), V.Vvod(textBox3), V.Vvod(textBox4), V.Vvod(textBox5), V.Vvod(textBox6));
            V.Vivod(q[0], textBox7);
            V.Vivod(q[1], textBox8);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form x = new title();
            x.Show();
            this.Close();
        }
    }
}
