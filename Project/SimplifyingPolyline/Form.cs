using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp_LR_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<Point> pointList;
        public List<Point> resultPointList;
        public List<Point> backUpPointList;

        Graphics graphics, graphics2;
        Pen pen;
        public int x = -1;
        public int y = -1;
        public bool flag = false;

        public Form()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 10);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            graphics = panelDrawing.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics2 = panelAfterProc.CreateGraphics();

            pointList = new List<Point>();
            resultPointList = new List<Point>();
            backUpPointList = new List<Point>();
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag && e.X != -1 && e.Y != -1 && e.X <= panelDrawing.Width && e.Y <= panelDrawing.Height)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);

                x = e.X;
                y = e.Y;
                pointList.Add(new Point(x, y));
            }
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();
        }

        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            graphics.Clear(panelDrawing.BackColor);
            graphics2.Clear(panelAfterProc.BackColor);
            backUpPointList.Clear();
            if (!flag)
            {
                flag = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag) flag = false;

            backUpPointList.AddRange(pointList); // Изначальные точки.

            resultPointList = DouglasPeuckerReduction(pointList, (int)numericUpDownEpsilonValue.Value);

            for (var i = 0; i < resultPointList.Count() - 1; i++)
            {
                graphics2.DrawLine(pen, resultPointList[i], resultPointList[i + 1]);
            }
            labelBeforeProc.Text = "До обработки: " + pointList.Count().ToString() + " точек";
            labelAfterProc.Text = "После обработки: " + resultPointList.Count().ToString() + " точек";
            resultPointList.Clear();
            pointList.Clear();
        }

        public static List<Point> DouglasPeuckerReduction (List<Point> points, double epsilon)
        {
            if (points == null || points.Count < 3) return points;

            int firstPoint = 0;
            int lastPoint = points.Count - 1;
            List<int> pointIndexsToKeep = new List<int>();

            //Add the first and last index to the keepers
            pointIndexsToKeep.Add(firstPoint);
            pointIndexsToKeep.Add(lastPoint);

            //The first and the last point cannot be the same
            while (points[firstPoint].Equals(points[lastPoint]))
            {
                lastPoint--;
            }

            DouglasPeuckerReduction(points, firstPoint, lastPoint, epsilon, ref pointIndexsToKeep);
            List<Point> returnPoints = new List<Point>();
            pointIndexsToKeep.Sort();
            foreach (int index in pointIndexsToKeep)
            {
                returnPoints.Add(points[index]);
            }

            return returnPoints;
        }

        private static void DouglasPeuckerReduction(List<Point>points, int firstPoint, int lastPoint, double tolerance, ref List<int> pointIndexsToKeep)
        {
            double maxDistance = 0;
            int indexFarthest = 0;

            for (int index = firstPoint; index < lastPoint; index++)
            {
                double distance = PerpendicularDistance
                    (points[firstPoint], points[lastPoint], points[index]);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    indexFarthest = index;
                }
            }

            if (maxDistance > tolerance && indexFarthest != 0)
            {
                //Add the largest point that exceeds the tolerance
                pointIndexsToKeep.Add(indexFarthest);

                DouglasPeuckerReduction(points, firstPoint,
                indexFarthest, tolerance, ref pointIndexsToKeep);
                DouglasPeuckerReduction(points, indexFarthest,
                lastPoint, tolerance, ref pointIndexsToKeep);
            }
        }

        private void button_reDraw_Click(object sender, EventArgs e)
        {
            graphics2.Clear(panelAfterProc.BackColor);

            List<Point> points = new List<Point>(backUpPointList);

            points = DouglasPeuckerReduction(points, (int)numericUpDownEpsilonValue.Value);
            for (var i = 0; i < points.Count() - 1; i++)
            {
                graphics2.DrawLine(pen, points[i], points[i + 1]);
            }
            labelBeforeProc.Text = "До обработки: " + backUpPointList.Count().ToString() + " точек";
            labelAfterProc.Text = "После обработки: " + points.Count().ToString() + " точек";
        }

        private void numericUpDownEpsilonValue_ValueChanged(object sender, EventArgs e) => button_reDraw_Click(sender, e);

        public static double PerpendicularDistance (Point Point1, Point Point2, Point Point)
        {
            double area = Math.Abs(.5 * (Point1.X * Point2.Y + Point2.X * Point.Y + Point.X * Point1.Y - Point2.X * Point1.Y - Point.X * Point2.Y - Point1.X * Point.Y));
            double bottom = Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) +
            Math.Pow(Point1.Y - Point2.Y, 2));
            double height = area / bottom * 2;

            return height;
        }
    }
}