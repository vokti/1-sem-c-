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
    public partial class LW1title : Form
    {
        public LW1title()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form f2 = new title();
            f2.Show();
            this.Hide();
        }

        private void LW1title_Load(object sender, EventArgs e)
        {

        }

    }
}
