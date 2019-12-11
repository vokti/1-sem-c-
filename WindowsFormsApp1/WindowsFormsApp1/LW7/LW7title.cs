using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1.LW7
{
    public partial class LW7title : Form
    {
        public LW7title()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form x = new LW7();
            x.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form x = new title();
            x.Show();
            this.Close();
        }

        private void LW7title_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath z = new GraphicsPath();
            z.AddEllipse(0,-300,this.Width,800);
            this.Region = new Region(z);
        }
    }
}
