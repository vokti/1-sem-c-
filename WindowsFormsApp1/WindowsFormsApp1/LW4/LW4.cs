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

namespace WindowsFormsApp1.LW4
{
    public partial class LW4 : Form
    {
        public LW4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LWlib.VV x=null;
            LWlib.LW4C a=null;
            x.Vivod(a.EX(x.Vvod(textBox1), x.Vvod(textBox2), x.Vvod(textBox3), x.Vvod(textBox4), x.Vvod(textBox5)),textBox6);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form x = new title();
            x.Show();
            this.Close();
        }
    }
}
