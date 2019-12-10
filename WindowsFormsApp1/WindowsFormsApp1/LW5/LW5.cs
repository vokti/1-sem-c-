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

namespace WindowsFormsApp1.LW5
{
    public partial class LW5 : Form
    {
        public LW5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VV Vvi = new VV();
            LW5c Ex = new LW5c();
            Vvi.Vivod(Ex.Ex(dataGridView1, Vvi.Vvod(textBox1), Vvi.Vvod(textBox6), Vvi.Vvod(textBox2)), textBox3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form x = new LW5title();
            x.Show();
            this.Close();
        }
    }
}
