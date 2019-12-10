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
    public class LW5c
    {
        public void Vivod(DataGridView l, int n, double x, double y)
        {
            l.Rows.Add(n, x, y);
        }

        public double Ex (DataGridView l,double a, double b, double h)
        {
            int t = 0;
            double y = 0;
            double s = a*Math.Exp(-a);
            for (double i = a; i <= b; i += h)
            {
                y = i * Math.Exp(-i);
                t += 1;
                Vivod(l, t, i, y);
                if (y > s)
                {
                    s = y;
                }
            }
            return s;
        }
    }

    public class LW6c
    {
        public void Vivod(DataGridView l, int n,int ny, double x, double y, double z)
        {
            l.Rows.Add(n,ny, x, y, z);
        }
        public double[] Ex(DataGridView l , double ax,double bx,double ay,double by,double hx,double hy)
        {
            double c = 1;
            double q = 0;
            double opx = ax;
            double opy = ay;
            for (int x = 0; x <= Math.Abs((bx - ax) / hx); x++)
            {
                opy = ay;
                for (int i = 0; x <= Math.Abs((by - ay) / hy); i++)
                {
                    l.Rows.Add(x,i,opx,opy,Math.Pow(opx,8)-opy-0.4*Math.Pow(x,3)-1.2);


                }
            }
        }
    }
}
