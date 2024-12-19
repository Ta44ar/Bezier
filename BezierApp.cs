using System.Windows.Forms;

namespace BezierApp
{
    public partial class BezierApp : Form
    {
        private bool isDragging = false;
        private Point selectedPoint;
        private string selectedPointName;

        public BezierApp()
        {
            InitializeComponent();
            InitializeNumericUpDowns();
            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);

        }

        private void InitializeNumericUpDowns()
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

            numericUpDownStartX.Value = maxX / 4;
            numericUpDownStartY.Value = maxY / 2;
            numericUpDownControlPoint1X.Value = maxX / 2;
            numericUpDownControlPoint1Y.Value = maxY / 4;
            numericUpDownControlPoint2X.Value = maxX / 2;
            numericUpDownControlPoint2Y.Value = 3 * maxY / 4;
            numericUpDownEndX.Value = 3 * maxX / 4;
            numericUpDownEndY.Value = maxY / 2;
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

            // Get points for curve from NumericUpDowns.
            Point[] controlPoints =
            {
                new Point((int)numericUpDownStartX.Value, (int)numericUpDownStartY.Value),
                new Point((int)numericUpDownControlPoint1X.Value, (int)numericUpDownControlPoint1Y.Value),
                new Point((int)numericUpDownControlPoint2X.Value, (int)numericUpDownControlPoint2Y.Value),
                new Point((int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value)
            };

            // Draw custom bezier curve.
            DrawCustomBezier(e.Graphics, blackPen, controlPoints);

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
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point start = new Point((int)numericUpDownStartX.Value, (int)numericUpDownStartY.Value);
            Point p1 = new Point((int)numericUpDownControlPoint1X.Value, (int)numericUpDownControlPoint1Y.Value);
            Point p2 = new Point((int)numericUpDownControlPoint2X.Value, (int)numericUpDownControlPoint2Y.Value);
            Point end = new Point((int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value);

            if (IsPointClicked(e.Location, start))
            {
                isDragging = true;
                selectedPoint = start;
                selectedPointName = "start";
            }
            else if (IsPointClicked(e.Location, p1))
            {
                isDragging = true;
                selectedPoint = p1;
                selectedPointName = "p1";
            }
            else if (IsPointClicked(e.Location, p2))
            {
                isDragging = true;
                selectedPoint = p2;
                selectedPointName = "p2";
            }
            else if (IsPointClicked(e.Location, end))
            {
                isDragging = true;
                selectedPoint = end;
                selectedPointName = "end";
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                switch (selectedPointName)
                {
                    case "start":
                        numericUpDownStartX.Value = e.X;
                        numericUpDownStartY.Value = e.Y;
                        break;
                    case "p1":
                        numericUpDownControlPoint1X.Value = e.X;
                        numericUpDownControlPoint1Y.Value = e.Y;
                        break;
                    case "p2":
                        numericUpDownControlPoint2X.Value = e.X;
                        numericUpDownControlPoint2Y.Value = e.Y;
                        break;
                    case "end":
                        numericUpDownEndX.Value = e.X;
                        numericUpDownEndY.Value = e.Y;
                        break;
                }
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

        private void customBezierButton_Click(object sender, EventArgs e)
        {

        }
    }
}
