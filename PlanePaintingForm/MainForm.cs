using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanePaintingForm
{
    public partial class MainForm : Form
    {
        Pen defaultPen = new Pen(Color.Black);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Graphics g = pnlCanvas.CreateGraphics();            
            PaintHair(g);
        }

        private void PaintHair(Graphics g)
            => PaintHair(g, Point.Empty);
        private void PaintHair(Graphics g, Point origin)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(174, 40));
            points.Add(new Point(125, 157));
            points.Add(new Point(139, 262));
            DrawCurveFromOrigin(g, origin, points.ToArray());
        }

        private void DrawCurveFromOrigin(Graphics g, Point origin, Point[] points)
        {
            Point[] newPoints = new Point[points.Length];
            for(int i = 0; i < points.Length; i++)
            {
                newPoints[i] = new Point(points[i].X + origin.X, points[i].Y + origin.Y);
            }
            g.DrawCurve(defaultPen, points);
        }
    }
}
