using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.LW4
{
    public partial class LW4title : Form
    {
        public LW4title()
        {
            InitializeComponent();
        }

        private void LW4title_Paint(object sender, PaintEventArgs e)
        {
            Image my_Image = Image.FromFile(@"C:\Users\super pc\Documents\GitHub\1-sem-c-\WindowsFormsApp1\WindowsFormsApp1\3.jpg");
            Graphics my_Graphics = Graphics.FromImage(my_Image);
            Graphics f = e.Graphics;
            f.DrawImage(my_Image, new PointF(0.0F, 0.0F));
            my_Graphics.Dispose();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.2;
            if (this.Opacity == 0)
            {
                this.timer1.Enabled = false;
                Form f = new LW4();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
