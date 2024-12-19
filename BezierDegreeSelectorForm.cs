using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BezierApp
{
    public partial class BezierDegreeSelectorForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedDegree { get; private set; }

        public BezierDegreeSelectorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.comboBoxDegree = new ComboBox();
            this.buttonConfirm = new Button();
            this.SuspendLayout();
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxDegree.Location = new Point(12, 12);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new Size(121, 23);
            this.comboBoxDegree.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new Point(12, 41);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new Size(121, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new EventHandler(this.buttonConfirm_Click);
            // 
            // BezierDegreeSelectorForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(150, 80);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxDegree);
            this.Name = "BezierDegreeSelectorForm";
            this.Text = "Select Degree";
            this.ResumeLayout(false);

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxDegree.SelectedIndex != -1)
            {
                SelectedDegree = comboBoxDegree.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a degree.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ComboBox comboBoxDegree;
        private Button buttonConfirm;
    }
}
