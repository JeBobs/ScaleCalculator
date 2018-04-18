using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleCalculator
{
    public partial class MainForm : Form
    {
        public string errorText = "Failed to parse, is the value an integer?";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            outputLabel.Text = "Let's get to calculating.";
        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {
            float value;
            float scaleFloat;
            string scaleString = comboBox1.SelectedItem.ToString();
            float.TryParse(scaleString, out scaleFloat);
            if (float.TryParse(valueBox.Text, out value))
            {
                float outputFloat = value * scaleFloat;
                string outputString = outputFloat.ToString();
                outputLabel.Text = outputString;
            }
            else
            {
                outputLabel.Text = errorText;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            if  (outputLabel.Text != errorText)
            {
                Clipboard.SetText(outputLabel.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
