namespace BezierApp
{
    partial class BezierApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            title = new Label();
            drawBezierButton = new Button();
            numericUpDownStartX = new NumericUpDown();
            numericUpDownStartY = new NumericUpDown();
            numericUpDownControlPoint1X = new NumericUpDown();
            numericUpDownControlPoint1Y = new NumericUpDown();
            numericUpDownControlPoint2X = new NumericUpDown();
            numericUpDownControlPoint2Y = new NumericUpDown();
            numericUpDownControlPoint3X = new NumericUpDown();
            numericUpDownControlPoint3Y = new NumericUpDown();
            numericUpDownEndX = new NumericUpDown();
            numericUpDownEndY = new NumericUpDown();
            xLabel = new Label();
            yLabel = new Label();
            startPointLabel = new Label();
            p1PointLabel = new Label();
            p2PointLabel = new Label();
            endPointLabel = new Label();
            degreeLabel = new Label();
            degreeComboBox = new ComboBox();
            p3PointLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint3X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint3Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndY).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(466, 37);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(820, 663);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += paintBezier;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 24F);
            title.ForeColor = SystemColors.ActiveCaptionText;
            title.Location = new Point(64, 68);
            title.Name = "title";
            title.Size = new Size(351, 54);
            title.TabIndex = 1;
            title.Text = "Bezier Line Drawer";
            // 
            // drawBezierButton
            // 
            drawBezierButton.Location = new Point(156, 539);
            drawBezierButton.Name = "drawBezierButton";
            drawBezierButton.Size = new Size(142, 49);
            drawBezierButton.TabIndex = 2;
            drawBezierButton.Text = "Draw Bezier Line";
            drawBezierButton.UseVisualStyleBackColor = true;
            drawBezierButton.Click += drawBezier;
            // 
            // numericUpDownStartX
            // 
            numericUpDownStartX.Location = new Point(175, 276);
            numericUpDownStartX.Name = "numericUpDownStartX";
            numericUpDownStartX.Size = new Size(86, 27);
            numericUpDownStartX.TabIndex = 3;
            // 
            // numericUpDownStartY
            // 
            numericUpDownStartY.Location = new Point(275, 276);
            numericUpDownStartY.Name = "numericUpDownStartY";
            numericUpDownStartY.Size = new Size(86, 27);
            numericUpDownStartY.TabIndex = 4;
            // 
            // numericUpDownControlPoint1X
            // 
            numericUpDownControlPoint1X.Location = new Point(175, 322);
            numericUpDownControlPoint1X.Name = "numericUpDownControlPoint1X";
            numericUpDownControlPoint1X.Size = new Size(86, 27);
            numericUpDownControlPoint1X.TabIndex = 5;
            // 
            // numericUpDownControlPoint1Y
            // 
            numericUpDownControlPoint1Y.Location = new Point(275, 322);
            numericUpDownControlPoint1Y.Name = "numericUpDownControlPoint1Y";
            numericUpDownControlPoint1Y.Size = new Size(86, 27);
            numericUpDownControlPoint1Y.TabIndex = 6;
            // 
            // numericUpDownControlPoint2X
            // 
            numericUpDownControlPoint2X.Location = new Point(175, 369);
            numericUpDownControlPoint2X.Name = "numericUpDownControlPoint2X";
            numericUpDownControlPoint2X.Size = new Size(86, 27);
            numericUpDownControlPoint2X.TabIndex = 7;
            // 
            // numericUpDownControlPoint2Y
            // 
            numericUpDownControlPoint2Y.Location = new Point(275, 369);
            numericUpDownControlPoint2Y.Name = "numericUpDownControlPoint2Y";
            numericUpDownControlPoint2Y.Size = new Size(86, 27);
            numericUpDownControlPoint2Y.TabIndex = 8;
            // 
            // numericUpDownEndX
            // 
            numericUpDownEndX.Location = new Point(175, 461);
            numericUpDownEndX.Name = "numericUpDownEndX";
            numericUpDownEndX.Size = new Size(86, 27);
            numericUpDownEndX.TabIndex = 9;
            // 
            // numericUpDownEndY
            // 
            numericUpDownEndY.Location = new Point(275, 461);
            numericUpDownEndY.Name = "numericUpDownEndY";
            numericUpDownEndY.Size = new Size(86, 27);
            numericUpDownEndY.TabIndex = 10;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Font = new Font("Segoe UI", 13F);
            xLabel.Location = new Point(208, 228);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(31, 30);
            xLabel.TabIndex = 11;
            xLabel.Text = "X:";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Font = new Font("Segoe UI", 13F);
            yLabel.Location = new Point(302, 228);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(30, 30);
            yLabel.TabIndex = 12;
            yLabel.Text = "Y:";
            // 
            // startPointLabel
            // 
            startPointLabel.AutoSize = true;
            startPointLabel.Font = new Font("Segoe UI", 13F);
            startPointLabel.Location = new Point(64, 270);
            startPointLabel.Name = "startPointLabel";
            startPointLabel.Size = new Size(78, 30);
            startPointLabel.TabIndex = 13;
            startPointLabel.Text = "START:";
            // 
            // p1PointLabel
            // 
            p1PointLabel.AutoSize = true;
            p1PointLabel.Font = new Font("Segoe UI", 13F);
            p1PointLabel.Location = new Point(100, 316);
            p1PointLabel.Name = "p1PointLabel";
            p1PointLabel.Size = new Size(42, 30);
            p1PointLabel.TabIndex = 14;
            p1PointLabel.Text = "P1:";
            // 
            // p2PointLabel
            // 
            p2PointLabel.AutoSize = true;
            p2PointLabel.Font = new Font("Segoe UI", 13F);
            p2PointLabel.Location = new Point(100, 363);
            p2PointLabel.Name = "p2PointLabel";
            p2PointLabel.Size = new Size(42, 30);
            p2PointLabel.TabIndex = 15;
            p2PointLabel.Text = "P2:";
            // 
            // endPointLabel
            // 
            endPointLabel.AutoSize = true;
            endPointLabel.Font = new Font("Segoe UI", 13F);
            endPointLabel.Location = new Point(82, 455);
            endPointLabel.Name = "endPointLabel";
            endPointLabel.Size = new Size(60, 30);
            endPointLabel.TabIndex = 16;
            endPointLabel.Text = "END:";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new Point(99, 146);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new Size(140, 20);
            degreeLabel.TabIndex = 18;
            degreeLabel.Text = "Bezier degree (0-4):";
            // 
            // degreeComboBox
            // 
            degreeComboBox.FormattingEnabled = true;
            degreeComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            degreeComboBox.Location = new Point(245, 143);
            degreeComboBox.Name = "degreeComboBox";
            degreeComboBox.Size = new Size(99, 28);
            degreeComboBox.TabIndex = 19;
            degreeComboBox.Text = "3";
            // 
            // p3PointLabel
            // 
            p3PointLabel.AutoSize = true;
            p3PointLabel.Font = new Font("Segoe UI", 13F);
            p3PointLabel.Location = new Point(100, 409);
            p3PointLabel.Name = "p3PointLabel";
            p3PointLabel.Size = new Size(42, 30);
            p3PointLabel.TabIndex = 22;
            p3PointLabel.Text = "P3:";
            // 
            // numericUpDownControlPoint3X
            // 
            numericUpDownControlPoint3X.Location = new Point(275, 415);
            numericUpDownControlPoint3X.Name = "numericUpDownControlPoint3X";
            numericUpDownControlPoint3X.Size = new Size(86, 27);
            numericUpDownControlPoint3X.TabIndex = 21;
            // 
            // numericUpDownControlPoint3Y
            // 
            numericUpDownControlPoint3Y.Location = new Point(175, 415);
            numericUpDownControlPoint3Y.Name = "numericUpDownControlPoint3Y";
            numericUpDownControlPoint3Y.Size = new Size(86, 27);
            numericUpDownControlPoint3Y.TabIndex = 20;
            // 
            // BezierApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1324, 744);
            Controls.Add(p3PointLabel);
            Controls.Add(numericUpDownControlPoint3X);
            Controls.Add(numericUpDownControlPoint3Y);
            Controls.Add(degreeComboBox);
            Controls.Add(degreeLabel);
            Controls.Add(endPointLabel);
            Controls.Add(p2PointLabel);
            Controls.Add(p1PointLabel);
            Controls.Add(startPointLabel);
            Controls.Add(yLabel);
            Controls.Add(xLabel);
            Controls.Add(numericUpDownEndY);
            Controls.Add(numericUpDownEndX);
            Controls.Add(numericUpDownControlPoint2Y);
            Controls.Add(numericUpDownControlPoint2X);
            Controls.Add(numericUpDownControlPoint1Y);
            Controls.Add(numericUpDownControlPoint1X);
            Controls.Add(numericUpDownStartY);
            Controls.Add(numericUpDownStartX);
            Controls.Add(drawBezierButton);
            Controls.Add(title);
            Controls.Add(pictureBox);
            Name = "BezierApp";
            Text = "BezierApp";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1X).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2X).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEndY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint3X).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint3Y).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label title;
        private Button drawBezierButton;
        private NumericUpDown numericUpDownStartX;
        private NumericUpDown numericUpDownStartY;
        private NumericUpDown numericUpDownControlPoint1X;
        private NumericUpDown numericUpDownControlPoint1Y;
        private NumericUpDown numericUpDownControlPoint2X;
        private NumericUpDown numericUpDownControlPoint2Y;
        private NumericUpDown numericUpDownControlPoint3X;
        private NumericUpDown numericUpDownControlPoint3Y;
        private NumericUpDown numericUpDownEndX;
        private NumericUpDown numericUpDownEndY;
        private Label xLabel;
        private Label yLabel;
        private Label startPointLabel;
        private Label p1PointLabel;
        private Label p2PointLabel;
        private Label p3PointLabel;
        private Label endPointLabel;
        private Label degreeLabel;
        private ComboBox degreeComboBox;
    }
}