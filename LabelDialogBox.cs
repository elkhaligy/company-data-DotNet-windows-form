using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class LabelDialogBox : Form
    {
        // In this datatype
        // we have:
        // selected font
        // selected size
        // selected color
        // new text

        // so make getters and setters for each of them

        // the flow is like that
        // the main form opens this dialog
        // the user input the data
        // the data gets stored as a state in this datatype
        // the main form access all these states as they have
        // setters and getters
        // the main form updates the company label

        // for extra convinence
        // when the main form creates this object
        // pass the old values to it, to make them preselected
        public string SelectedFont { get; private set; }
        public int SelectedSize { get; private set; }
        public Color SelectedColor { get; set; }
        public string NewText { get; private set; }

        public LabelDialogBox(string currentText, string currentFont, int currentSize, Color currentColor)
        {
            InitializeComponent();

            SelectedFont = currentFont;
            SelectedColor = currentColor;

            /* Update the current state with old state */
            // Font
            if (SelectedFont == "Times New Roman")
                timesNewRomanRadioButton.Checked = true;
            else if (SelectedFont == "Arial")
                arialRadioButton.Checked = true;
            else if (SelectedFont == "Microsoft Sans Serif")
                MsSerifRadioButton.Checked = true;

            // Color
            colorDialog1.Color = currentColor;

            // Size
            SelectedSize = currentSize;
            switch (SelectedSize)
            {
                case 24:
                    largeSizeRadioButton.Checked = true;
                    break;
                case 16:
                    mediumSizeRadioButton.Checked = true;
                    break;
                case 12:
                    smallSizeRadioButton.Checked = true;
                    break;
            }

            // Text
            NewText = currentText;
            currTextBox.Text = NewText;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Set the label dialog box object state */
            // Selected font
            if (timesNewRomanRadioButton.Checked)
                SelectedFont = "Times New Roman";
            else if (arialRadioButton.Checked)
                SelectedFont = "Arial";
            else if (MsSerifRadioButton.Checked)
                SelectedFont = "Microsoft Sans Serif";

            // Selected color is set at button3_Click

            // Selected size
            if (largeSizeRadioButton.Checked)
                SelectedSize = 24;
            else if (mediumSizeRadioButton.Checked)
                SelectedSize = 16;
            else if (smallSizeRadioButton.Checked)
                SelectedSize = 12;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog1.Color;
            }
        }
    }
}
