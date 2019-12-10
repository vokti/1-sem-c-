using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1.LW5
{
    public partial class LW5title : Form
    {
        public LW5title()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form x = new LW5();
            x.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form y = new title();
            y.Show();
            this.Close();
        }

        private void LW5title_Paint(object sender, PaintEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Bitmap xolst = new Bitmap(currentDirectory + @"\bin\image.jpg");
            pictureBox1.Image = xolst;
        }
    }
}
