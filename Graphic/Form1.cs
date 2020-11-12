using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Red, 3);
        Point point1 = new Point(-1, -1);
        Point point2 = new Point(-1, -1);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawLine(object sender,EventArgs e)
        {
            Graphics g = CreateGraphics();
            MouseEventArgs mouse = (MouseEventArgs)e;
            point1.X = point2.X;
            point1.Y = point2.Y;
            point2.X = mouse.X;
            point2.Y = mouse.Y;
            if (point1.X!=-1 && point1.Y!=-1) g.DrawLine(pen, point1, point2);
        }

        private void ResetPoint(object sender, EventArgs e)
        {
            point1.X = -1;
            point2.X = -1;
            point1.Y = -1;
            point2.Y = -1;
        }
        
        private void VeHCN(object sender,EventArgs e)
        {
            Graphics g = CreateGraphics();
            MouseEventArgs mouse = (MouseEventArgs)e;
            point1.X = point2.X;
            point1.Y = point2.Y;
            point2.X = mouse.X;
            point2.Y = mouse.Y;
            if (point1.X != -1 && point1.Y != -1)
            {
                SolidBrush solid = new SolidBrush(Color.FromArgb(255, 0, 0));
                g.FillRectangle(solid, point1.X, point1.Y,Math.Abs(point1.X - point2.X), Math.Abs(point1.Y - point2.Y));
            }
        }
    }
}
