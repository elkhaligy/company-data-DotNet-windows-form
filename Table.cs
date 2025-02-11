namespace WinFormsApp
{
    public class Table
    {
        private int[] years;
        private int[] revenues;

        public Table(int[] years, int[] revenues)
        {
            this.years = years;
            this.revenues = revenues;
        }

        public void drawTable(Graphics g)
        {
            // External Margin
            int marginY = 200;
            int marginX = 440;

            // For a table I need
            // Table width
            // Row height
            // Columns numbers
            // Columns width

            int width = 1100;
            int rowHeight = 40;
            int colCount = years.Length + 1; // +1 for headers
            int colWidth = width / colCount; // Dynamic column width

            // Define fonts and pens
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font dataFont = new Font("Arial", 12);
            Pen gridPen = Pens.Black;
            Brush textBrush = Brushes.Black;
            g.DrawString("Company Table Report", new Font("Arial", 14), textBrush, marginX, marginY - 35);

            // Draw table grid and text
            for (int i = 0; i < colCount; i++)
            {
                int x = i * colWidth;

                // Alternate background color for even columns
                if (i % 2 == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.LightBlue), marginX + x, marginY, colWidth, rowHeight * 2);
                }
                // Draw column lines
                g.DrawLine(new Pen(Brushes.Black, 3), marginX + x, marginY + 0, marginX + x, marginY + rowHeight * 2);
                // Draw headers
                if (i == 0)
                {
                    g.DrawString("Year", headerFont, textBrush, marginX + x + 5, marginY + 5);
                    g.DrawString("Revenue", headerFont, textBrush, marginX + x + 5, marginY + rowHeight + 5);
                }
                else
                {
                    g.DrawString(years[i - 1].ToString(), dataFont, textBrush, marginX + x + 20, marginY + 5);
                    g.DrawString(revenues[i - 1].ToString(), dataFont, textBrush, marginX + x + 20, marginY + rowHeight + 5);
                }
            }
            // Draw last column line
            g.DrawLine(new Pen(Brushes.Black, 3), marginX + width, marginY + 0, marginX + width, marginY + rowHeight * 2);
            // Draw row lines
            g.DrawLine(new Pen(Brushes.Black, 3), marginX + 0, marginY, marginX + width, marginY);
            g.DrawLine(new Pen(Brushes.Black, 3), marginX + 0, marginY + rowHeight, marginX + width, marginY + rowHeight);
            g.DrawLine(new Pen(Brushes.Black, 3), marginX + 0, marginY + rowHeight * 2, marginX + width, marginY + rowHeight * 2);
        }
    }

    

}
