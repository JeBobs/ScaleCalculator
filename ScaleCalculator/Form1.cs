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
    public partial class Form1 : Form
    {
        int value = 0;
        int scaleInt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        void update ()
        {
            string scaleString = comboBox1.SelectedItem.ToString();
            Int32.TryParse(scaleString, out scaleInt);
            if (Int32.TryParse(valueBox.Text, out value))
            {
                int outputInt = value * scaleInt;
                string outputString = outputInt.ToString();
                outputLabel.Text = outputString;
            }
            else
            {
                outputLabel.Text = "Failed to parse, is the value an integer?";
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputLabel.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
