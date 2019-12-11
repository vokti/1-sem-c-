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

namespace WindowsFormsApp1.LW7
{
    public partial class LW7 : Form
    {
        public LW7()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LWlib.VV po = new LWlib.VV();
            LWlib.LW7c ui = new LWlib.LW7c();
            po.Vivod(ui.Ex(dataGridView1,po.Vvod(textBox1),po.Vvod(textBox2)),textBox3);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form x = new title();
            x.Show();
            this.Close();
        }
    }
}
