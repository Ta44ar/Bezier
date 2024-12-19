using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BezierApp
{
    public partial class BezierApp : Form
    {
        private bool isDragging = false;
        private Point selectedPoint;
        private int selectedPointIndex;
        private List<Point> controlPoints = new List<Point>();

        public BezierApp()
        {
            InitializeComponent();
            InitializeCubicBezier();
            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
            degreeComboBox.SelectedIndexChanged += new EventHandler(comboBoxDegree_SelectedIndexChanged);
        }

        private void comboBoxDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (degreeComboBox.SelectedIndex)
            {
                case 0:
                    InitializeDegree0();
                    break;
                case 1:
                    InitializeDegree1();
                    break;
                case 2:
                    InitializeQuadraticBezier();
                    break;
                case 3:
                    InitializeCubicBezier();
                    break;
                case 4:
                    InitializeDegree4();
                    break;
            }
            pictureBox.Invalidate();
        }

        private void InitializeDegree0()
        {
            pictureBox.AllowDrop = true;

            int maxX = pictureBox.Width;
            int maxY = pictureBox.Height;

            numericUpDownStartX.Maximum = maxX;
            numericUpDownStartY.Maximum = maxY;

            controlPoints.Clear();
            controlPoints.Add(new Point(maxX / 2, maxY / 2)); // Single point

            UpdateNumericUpDowns();
        }

        private void InitializeDegree1()
        {
            pictureBox.AllowDrop = true;

            int maxX = pictureBox.Width;
            int maxY = pictureBox.Height;

            numericUpDownStartX.Maximum = maxX;
            numericUpDownStartY.Maximum = maxY;
            numericUpDownEndX.Maximum = maxX;
            numericUpDownEndY.Maximum = maxY;

            controlPoints.Clear();
            controlPoints.Add(new Point(maxX / 4, maxY / 2)); // Start point
            controlPoints.Add(new Point(3 * maxX / 4, maxY / 2)); // End point

            UpdateNumericUpDowns();
        }

        private void InitializeQuadraticBezier()
        {
            pictureBox.AllowDrop = true;

            int maxX = pictureBox.Width;
            int maxY = pictureBox.Height;

            numericUpDownStartX.Maximum = maxX;
            numericUpDownStartY.Maximum = maxY;
            numericUpDownControlPoint1X.Maximum = maxX;
            numericUpDownControlPoint1Y.Maximum = maxY;
            numericUpDownEndX.Maximum = maxX;
            numericUpDownEndY.Maximum = maxY;

            controlPoints.Clear();
            controlPoints.Add(new Point(maxX / 4, maxY / 2)); // Start point
            controlPoints.Add(new Point(maxX / 2, maxY / 4)); // Control point
            controlPoints.Add(new Point(3 * maxX / 4, maxY / 2)); // End point

            UpdateNumericUpDowns();
        }

        private void InitializeCubicBezier()
        {
            pictureBox.AllowDrop = true;

            int maxX = pictureBox.Width;
            int maxY = pictureBox.Height;

            numericUpDownStartX.Maximum = maxX;
            numericUpDownStartY.Maximum = maxY;
            numericUpDownControlPoint1X.Maximum = maxX;
            numericUpDownControlPoint1Y.Maximum = maxY;
            numericUpDownControlPoint2X.Maximum = maxX;
            numericUpDownControlPoint2Y.Maximum = maxY;
            numericUpDownEndX.Maximum = maxX;
            numericUpDownEndY.Maximum = maxY;

            controlPoints.Clear();
            controlPoints.Add(new Point(maxX / 4, maxY / 2)); // Start point
            controlPoints.Add(new Point(maxX / 2, maxY / 4)); // Control point 1
            controlPoints.Add(new Point(maxX / 2, 3 * maxY / 4)); // Control point 2
            controlPoints.Add(new Point(3 * maxX / 4, maxY / 2)); // End point

            UpdateNumericUpDowns();
        }

        private void InitializeDegree4()
        {
            pictureBox.AllowDrop = true;

            int maxX = pictureBox.Width;
            int maxY = pictureBox.Height;

            numericUpDownStartX.Maximum = maxX;
            numericUpDownStartY.Maximum = maxY;
            numericUpDownControlPoint1X.Maximum = maxX;
            numericUpDownControlPoint1Y.Maximum = maxY;
            numericUpDownControlPoint2X.Maximum = maxX;
            numericUpDownControlPoint2Y.Maximum = maxY;
            numericUpDownControlPoint3X.Maximum = maxX;
            numericUpDownControlPoint3Y.Maximum = maxY;
            numericUpDownEndX.Maximum = maxX;
            numericUpDownEndY.Maximum = maxY;

            controlPoints.Clear();
            controlPoints.Add(new Point(maxX / 5, maxY / 2)); // Start point
            controlPoints.Add(new Point(2 * maxX / 5, maxY / 4)); // Control point 1
            controlPoints.Add(new Point(3 * maxX / 5, 3 * maxY / 4)); // Control point 2
            controlPoints.Add(new Point(4 * maxX / 5, maxY / 4)); // Control point 3
            controlPoints.Add(new Point(4 * maxX / 5, maxY / 2)); // End point

            UpdateNumericUpDowns();
        }

        private void UpdateNumericUpDowns()
        {
            // Default value to indicate uninitialized fields
            decimal defaultValue = 0;

            if (controlPoints.Count >= 1)
            {
                numericUpDownStartX.Value = controlPoints[0].X;
                numericUpDownStartY.Value = controlPoints[0].Y;
            }
            else
            {
                numericUpDownStartX.Value = defaultValue;
                numericUpDownStartY.Value = defaultValue;
            }

            if (controlPoints.Count >= 2)
            {
                numericUpDownControlPoint1X.Value = controlPoints[1].X;
                numericUpDownControlPoint1Y.Value = controlPoints[1].Y;
            }
            else
            {
                numericUpDownControlPoint1X.Value = defaultValue;
                numericUpDownControlPoint1Y.Value = defaultValue;
            }

            if (controlPoints.Count >= 3)
            {
                numericUpDownControlPoint2X.Value = controlPoints[2].X;
                numericUpDownControlPoint2Y.Value = controlPoints[2].Y;
            }
            else
            {
                numericUpDownControlPoint2X.Value = defaultValue;
                numericUpDownControlPoint2Y.Value = defaultValue;
            }

            if (controlPoints.Count >= 4)
            {
                numericUpDownEndX.Value = controlPoints[3].X;
                numericUpDownEndY.Value = controlPoints[3].Y;
            }
            else
            {
                numericUpDownEndX.Value = defaultValue;
                numericUpDownEndY.Value = defaultValue;
            }

            if (controlPoints.Count >= 5)
            {
                numericUpDownControlPoint3X.Value = controlPoints[4].X;
                numericUpDownControlPoint3Y.Value = controlPoints[4].Y;
            }
            else
            {
                numericUpDownControlPoint3X.Value = defaultValue;
                numericUpDownControlPoint3Y.Value = defaultValue;
            }
        }

        private void DrawCustomBezier(Graphics g, Pen pen, Point[] controlPoints)
        {
            const int steps = 100;
            PointF[] bezierPoints = new PointF[steps + 1];

            for (int i = 0; i <= steps; i++)
            {
                float t = i / (float)steps;
                bezierPoints[i] = CalculateBezierPoint(t, controlPoints);
            }

            g.DrawLines(pen, bezierPoints);
        }

        private PointF CalculateBezierPoint(float t, Point[] controlPoints)
        {
            int n = controlPoints.Length - 1;
            PointF[] temp = new PointF[n + 1];
            for (int i = 0; i <= n; i++)
            {
                temp[i] = new PointF(controlPoints[i].X, controlPoints[i].Y);
            }

            for (int r = 1; r <= n; r++)
            {
                for (int i = 0; i <= n - r; i++)
                {
                    temp[i].X = (1 - t) * temp[i].X + t * temp[i + 1].X;
                    temp[i].Y = (1 - t) * temp[i].Y + t * temp[i + 1].Y;
                }
            }

            return temp[0];
        }

        private void paintBezier(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 2);
            Pen redPen = new Pen(Color.Red, 7);

            // Draw custom bezier curve.
            DrawCustomBezier(e.Graphics, blackPen, controlPoints.ToArray());

            // Draw points.
            foreach (var point in controlPoints)
            {
                DrawPoint(e.Graphics, redPen, point);
            }
        }

        private void DrawPoint(Graphics g, Pen pen, Point point)
        {
            g.DrawEllipse(pen, point.X - 2, point.Y - 2, 4, 4);
            g.FillEllipse(new SolidBrush(pen.Color), point.X - 2, point.Y - 2, 4, 4);
        }

        private void drawBezier(object sender, EventArgs e)
        {
            UpdateControlPointsFromNumericUpDowns();
            pictureBox.Invalidate();
        }

        private void UpdateControlPointsFromNumericUpDowns()
        {
            if (controlPoints.Count >= 1)
            {
                controlPoints[0] = new Point((int)numericUpDownStartX.Value, (int)numericUpDownStartY.Value);
            }

            if (controlPoints.Count >= 2)
            {
                controlPoints[1] = new Point((int)numericUpDownControlPoint1X.Value, (int)numericUpDownControlPoint1Y.Value);
            }

            if (controlPoints.Count >= 3)
            {
                controlPoints[2] = new Point((int)numericUpDownControlPoint2X.Value, (int)numericUpDownControlPoint2Y.Value);
            }

            if (controlPoints.Count >= 4)
            {
                controlPoints[3] = new Point((int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value);
            }

            if (controlPoints.Count >= 5)
            {
                controlPoints[4] = new Point((int)numericUpDownControlPoint3X.Value, (int)numericUpDownControlPoint3Y.Value);
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < controlPoints.Count; i++)
            {
                if (IsPointClicked(e.Location, controlPoints[i]))
                {
                    isDragging = true;
                    selectedPoint = controlPoints[i];
                    selectedPointIndex = i;
                    break;
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = e.X;
                int newY = e.Y;

                // wymuszony drop przed granic¹ pictureBox
                if (newX < 3) newX = 3;
                if (newX > pictureBox.Width - 3) newX = pictureBox.Width - 3;
                if (newY < 3) newY = 3;
                if (newY > pictureBox.Height - 3) newY = pictureBox.Height - 3;

                controlPoints[selectedPointIndex] = new Point(newX, newY);
                UpdateNumericUpDowns();
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private bool IsPointClicked(Point clickPoint, Point point)
        {
            const int radius = 5;
            return (clickPoint.X >= point.X - radius && clickPoint.X <= point.X + radius &&
                    clickPoint.Y >= point.Y - radius && clickPoint.Y <= point.Y + radius);
        }


    }
}
