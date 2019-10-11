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
    public partial class LW3title : Form
    {
        public LW3title()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form sa = new PassWin();
            sa.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form na = new title();
            na.Show();
            this.Hide();
        }
    }
}
