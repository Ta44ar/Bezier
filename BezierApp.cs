namespace BezierApp
{
    public partial class BezierApp : Form
    {
        public BezierApp()
        {
            InitializeComponent();
            InitializeNumericUpDowns();
        }

        private void InitializeNumericUpDowns()
        {
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

        private void paintBezier(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 2);

            // Get points for curve from NumericUpDowns.
            Point start = new Point((int)numericUpDownStartX.Value, (int)numericUpDownStartY.Value);
            Point control1 = new Point((int)numericUpDownControlPoint1X.Value, (int)numericUpDownControlPoint1Y.Value);
            Point control2 = new Point((int)numericUpDownControlPoint2X.Value, (int)numericUpDownControlPoint2Y.Value);
            Point end = new Point((int)numericUpDownEndX.Value, (int)numericUpDownEndY.Value);

            // Draw bezier curve.
            e.Graphics.DrawBezier(blackPen, start, control1, control2, end);
        }

        private void drawBezier(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
