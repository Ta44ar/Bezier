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
            numericUpDownEndX = new NumericUpDown();
            numericUpDownEndY = new NumericUpDown();
            xLabel = new Label();
            yLabel = new Label();
            startPointLabel = new Label();
            p1PointLabel = new Label();
            p2PointLabel = new Label();
            endPointLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStartY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownControlPoint2Y).BeginInit();
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
            title.Location = new Point(49, 48);
            title.Name = "title";
            title.Size = new Size(351, 54);
            title.TabIndex = 1;
            title.Text = "Bezier Line Drawer";
            // 
            // drawBezierButton
            // 
            drawBezierButton.Location = new Point(143, 417);
            drawBezierButton.Name = "drawBezierButton";
            drawBezierButton.Size = new Size(142, 49);
            drawBezierButton.TabIndex = 2;
            drawBezierButton.Text = "Draw Bezier Line";
            drawBezierButton.UseVisualStyleBackColor = true;
            drawBezierButton.Click += drawBezier;
            // 
            // numericUpDownStartX
            // 
            numericUpDownStartX.Location = new Point(160, 188);
            numericUpDownStartX.Name = "numericUpDownStartX";
            numericUpDownStartX.Size = new Size(86, 27);
            numericUpDownStartX.TabIndex = 3;
            // 
            // numericUpDownStartY
            // 
            numericUpDownStartY.Location = new Point(260, 188);
            numericUpDownStartY.Name = "numericUpDownStartY";
            numericUpDownStartY.Size = new Size(86, 27);
            numericUpDownStartY.TabIndex = 4;
            // 
            // numericUpDownControlPoint1X
            // 
            numericUpDownControlPoint1X.Location = new Point(160, 234);
            numericUpDownControlPoint1X.Name = "numericUpDownControlPoint1X";
            numericUpDownControlPoint1X.Size = new Size(86, 27);
            numericUpDownControlPoint1X.TabIndex = 5;
            // 
            // numericUpDownControlPoint1Y
            // 
            numericUpDownControlPoint1Y.Location = new Point(260, 234);
            numericUpDownControlPoint1Y.Name = "numericUpDownControlPoint1Y";
            numericUpDownControlPoint1Y.Size = new Size(86, 27);
            numericUpDownControlPoint1Y.TabIndex = 6;
            // 
            // numericUpDownControlPoint2X
            // 
            numericUpDownControlPoint2X.Location = new Point(160, 281);
            numericUpDownControlPoint2X.Name = "numericUpDownControlPoint2X";
            numericUpDownControlPoint2X.Size = new Size(86, 27);
            numericUpDownControlPoint2X.TabIndex = 7;
            // 
            // numericUpDownControlPoint2Y
            // 
            numericUpDownControlPoint2Y.Location = new Point(260, 281);
            numericUpDownControlPoint2Y.Name = "numericUpDownControlPoint2Y";
            numericUpDownControlPoint2Y.Size = new Size(86, 27);
            numericUpDownControlPoint2Y.TabIndex = 8;
            // 
            // numericUpDownEndX
            // 
            numericUpDownEndX.Location = new Point(160, 328);
            numericUpDownEndX.Name = "numericUpDownEndX";
            numericUpDownEndX.Size = new Size(86, 27);
            numericUpDownEndX.TabIndex = 9;
            // 
            // numericUpDownEndY
            // 
            numericUpDownEndY.Location = new Point(260, 328);
            numericUpDownEndY.Name = "numericUpDownEndY";
            numericUpDownEndY.Size = new Size(86, 27);
            numericUpDownEndY.TabIndex = 10;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Font = new Font("Segoe UI", 13F);
            xLabel.Location = new Point(193, 140);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(31, 30);
            xLabel.TabIndex = 11;
            xLabel.Text = "X:";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Font = new Font("Segoe UI", 13F);
            yLabel.Location = new Point(287, 140);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(30, 30);
            yLabel.TabIndex = 12;
            yLabel.Text = "Y:";
            // 
            // startPointLabel
            // 
            startPointLabel.AutoSize = true;
            startPointLabel.Font = new Font("Segoe UI", 13F);
            startPointLabel.Location = new Point(49, 182);
            startPointLabel.Name = "startPointLabel";
            startPointLabel.Size = new Size(78, 30);
            startPointLabel.TabIndex = 13;
            startPointLabel.Text = "START:";
            // 
            // p1PointLabel
            // 
            p1PointLabel.AutoSize = true;
            p1PointLabel.Font = new Font("Segoe UI", 13F);
            p1PointLabel.Location = new Point(85, 228);
            p1PointLabel.Name = "p1PointLabel";
            p1PointLabel.Size = new Size(42, 30);
            p1PointLabel.TabIndex = 14;
            p1PointLabel.Text = "P1:";
            // 
            // p2PointLabel
            // 
            p2PointLabel.AutoSize = true;
            p2PointLabel.Font = new Font("Segoe UI", 13F);
            p2PointLabel.Location = new Point(85, 275);
            p2PointLabel.Name = "p2PointLabel";
            p2PointLabel.Size = new Size(42, 30);
            p2PointLabel.TabIndex = 15;
            p2PointLabel.Text = "P2:";
            // 
            // endPointLabel
            // 
            endPointLabel.AutoSize = true;
            endPointLabel.Font = new Font("Segoe UI", 13F);
            endPointLabel.Location = new Point(67, 322);
            endPointLabel.Name = "endPointLabel";
            endPointLabel.Size = new Size(60, 30);
            endPointLabel.TabIndex = 16;
            endPointLabel.Text = "END:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1324, 744);
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
        private NumericUpDown numericUpDownEndX;
        private NumericUpDown numericUpDownEndY;
        private Label xLabel;
        private Label yLabel;
        private Label startPointLabel;
        private Label p1PointLabel;
        private Label p2PointLabel;
        private Label endPointLabel;
    }
}
