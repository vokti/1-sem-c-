using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LWlib
{
    public class VV
    {
        public double Vvod(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
         public void Vivod(double x, TextBox t)
        {
            t.Text = Convert.ToString(x);
        }
    }
    public class LW4C
    {
        public double EX(double a,double b,double c,double x,double y)
        {
            if (x>=3 & x <= 4)
            {
                return Math.Sqrt(b * b + c * c);
            }
            else if (x < 3)
            {
                return Math.Min(a, Math.Max(x * x,Math.Max( y, c)));
            }
            else
            {
                return Math.Max(a * x + c, Math.Pow(y, 3));
            }
        }
    }
}
