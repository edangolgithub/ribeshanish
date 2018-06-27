using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish.evan
{
    public partial class EvanDrawing : Form
    {
        public EvanDrawing()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(hbrush);
            p.Width = 10;
        }
        Graphics g;
        bool draw = false;
        SolidBrush brushe = new SolidBrush(Color.BlueViolet);
        HatchBrush hbrush = new HatchBrush(HatchStyle.DiagonalCross, Color.CadetBlue, Color.DarkOrchid);
        Pen p;
        int prevX;
        int prevY;
        private void EvanDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            prevX = e.X;
            prevY = e.Y;
        }

        private void EvanDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if(draw)
            {
                //Graphics g = this.CreateGraphics();

                //g.FillEllipse(brushe, e.X, e.Y, 50, 50);


                g.DrawLine(p, prevX, prevY, e.X, e.Y);
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void EvanDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }
    }
}
