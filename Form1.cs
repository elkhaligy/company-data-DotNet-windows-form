using Microsoft.VisualBasic.Logging;
using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        /* ---------------- Fields ---------------- */

        /* --- Notes --- */
        // Compiler will move initialization of fields in the ctor automatically
        //private ContextMenuStrip contextMenu;
        /* --- --- */

        private CompanyLabel companyLabelObj;
        private Table tableObj;
        private BarChart barChartObj;
        int[] years = new int[] { 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997 };
        int[] revenues = new int[] { 150, 170, 180, 175, 200, 250, 210, 240, 280, 140 };

        /* --------------------------------------- */


        /* ---------------- Constructor ---------------- */

        public Form1()
        {
            InitializeComponent(); // Designer code
            DoubleBuffered = true; // Reduces flickering

            companyLabelObj = new CompanyLabel() { Text = "Lethal Company" };
            tableObj = new Table(
                [1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997],
                [150, 170, 180, 175, 200, 250, 210, 240, 280, 140]
                ); // This is a new expression, when passing the array
            barChartObj = new BarChart(
                [1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997],
                [150, 170, 180, 175, 200, 250, 210, 240, 280, 140]
                );
            KeyDown += new KeyEventHandler(OnKeyDown!);

            lineSolidToolStripMenuItem.Checked = true;
        }

        /* --------------------------------------- */


        /* ---------------- Methods ---------------- */

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control) // Check if Ctrl is held
            {
                if (e.KeyCode == Keys.R)
                {
                    barChartObj.ChangeLineGraphPenColor(Brushes.Red);
                    Invalidate();
                }
                else if (e.KeyCode == Keys.G)
                {
                    barChartObj.ChangeLineGraphPenColor(Brushes.Green);
                    Invalidate();
                }
                else if (e.KeyCode == Keys.B)
                {
                    barChartObj.ChangeLineGraphPenColor(Brushes.Blue);
                    Invalidate();
                }
            }
        }
        private void ChangeLineGraphPenColorGUI(object sender, EventArgs e)
        {
            string? color = sender.ToString();

            foreach (ToolStripMenuItem item in lineColorToolStripMenuItem.DropDownItems)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }
            switch (color)
            {
                case "Blue":
                    lineBlueToolStripMenuItem.Checked = true;
                    break;
                case "Red":
                    lineRedToolStripMenuItem.Checked = true;
                    break;
                case "Green":
                    lineGreenToolStripMenuItem.Checked = true;
                    break;
            }
            Brush newBrush = new SolidBrush(Color.FromName(color));
            barChartObj.ChangeLineGraphPenColor(newBrush);
            Invalidate();
        }

        private void ChangeLineGraphPenStyleGUI(object sender, EventArgs e)
        {
            DashStyle newStyle = DashStyle.Solid;


            foreach (ToolStripMenuItem item in lineStyleToolStripMenuItem.DropDownItems)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }
            switch (sender.ToString())
            {
                case "Dashed":
                    lineDashedToolStripMenuItem.Checked = true;
                    newStyle = DashStyle.Dash;
                    break;
                case "Dotted":
                    lineDottedToolStripMenuItem.Checked = true;
                    newStyle = DashStyle.Dot;
                    break;
                case "Solid":
                    lineSolidToolStripMenuItem.Checked = true;
                    newStyle = DashStyle.Solid;
                    break;
            }
            barChartObj.ChangeLineGraphPenStyle(newStyle);
            Invalidate();
        }


        private void ChangeRectangleColorGUI(object sender, EventArgs e)
        {
            barChartObj.ChangeRectangleColor(Color.FromName(sender?.ToString() ?? "Black"));
            Invalidate();
        }

        private void ChangeRectangleStyleGUI(object sender, EventArgs e)
        {
            HatchStyle newStyle = HatchStyle.BackwardDiagonal;
            switch (sender.ToString())
            {
                case "Right":
                    newStyle = HatchStyle.Horizontal;
                    break;
                case "Left":
                    newStyle = HatchStyle.DashedHorizontal;
                    break;
                case "Crossed":
                    newStyle = HatchStyle.Cross;
                    break;
            }

            barChartObj.ChangeRectangleStyle(newStyle);
            Invalidate();
        }

        // This method is called by Windows OS whenever the form needs to be repainted
        // Windows pass the PaintEventArgs object, which contains the Graphics property
        // The graphics property can be used to custom paint on the form
        protected override void OnPaint(PaintEventArgs paintEventObj)
        {
            // Call the default painting logic first and then handle the overriden logic
            //base.OnPaint(paintEventObj);

            // Extract the graphics object to allow custom drawing on the form
            Graphics graphicsObj = paintEventObj.Graphics;

            // Draw the company label
            companyLabelObj.DrawOnCenter(graphicsObj);

            // Draw the company table
            tableObj.drawTable(graphicsObj);
            barChartObj.Draw(graphicsObj);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            X.Text = $"MouseX: {e.X}, MouseY: {e.Y}";
            int index = barChartObj.isInChart(e.X, e.Y);
            if (index != -1)
            {
                X.Text = $"MouseX: {e.X}, MouseY: {e.Y}, Year: {years[index]}, Revenue: {revenues[index]}";
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Check if right mouse button was clicked
            {
                if (barChartObj.isInChart(e.X, e.Y) != -1)
                {
                    RectangleContextMenuStrip.Show(this, e.Location);
                }
                else
                {
                    LineContextMenuStrip.Show(this, e.Location);
                }
            }
            else
            {
                int index = barChartObj.isInChart(e.X, e.Y);
                if (index != -1)
                {
                    MessageBox.Show($"Year {years[index]}\nRevenue {revenues[index]}");
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO");
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelDialogBox dialog = new LabelDialogBox(companyLabelObj.Text, companyLabelObj.Font.Name, (int)companyLabelObj.Font.Size, companyLabelObj.Brush.Color);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                /* Update the company label using the dialog state */
                /* Update the company label size using the dialog state */
                companyLabelObj.Font = new Font(dialog.SelectedFont, dialog.SelectedSize, FontStyle.Bold);
                /* Update the company label color using the dialog state */
                companyLabelObj.Brush = new SolidBrush(dialog.SelectedColor);
                /* Update the company text */
                if (dialog.NewText.Length > 0)
                    companyLabelObj.Text = dialog.NewText;

                Invalidate();
            }

        }
    }

}
